using Receita01.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Receita01.Comandos
{
     public class CancelarEdicaoCommand : ICommand
    {
        private ReceitasDeCervejaViewModel m_ViewModel;

        public CancelarEdicaoCommand(ReceitasDeCervejaViewModel viewModel)
        {
            m_ViewModel = viewModel;
        }

        public bool CanExecute(object parameter)
        {
            if(!string.IsNullOrEmpty(m_ViewModel.Nome) && !string.IsNullOrEmpty(m_ViewModel.ReceitaTxt) && m_ViewModel.Estilos != null)
                return true;
            else
            return false;
        }

        public event EventHandler CanExecuteChanged
        {
            add { CommandManager.RequerySuggested += value; }
            remove { CommandManager.RequerySuggested -= value; }
        }

        public void Execute(object parameter)
        {
            m_ViewModel.Nome = string.Empty;
            m_ViewModel.ReceitaTxt = string.Empty;
            m_ViewModel.Estilos = null;
            m_ViewModel.IdReceita = 0;

        }
    }
}
