using Receita01.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Receita01.Comandos
{
    public class CarregarReceitaCommand : ICommand
    {
        private ReceitasDeCervejaViewModel m_ViewModel;


        public CarregarReceitaCommand(ReceitasDeCervejaViewModel viewModel)
        {
            m_ViewModel = viewModel;
        }

        public bool CanExecute(object parameter)
        {
            return m_ViewModel.Receita != null;
        }

        public event EventHandler CanExecuteChanged
        {
            add { CommandManager.RequerySuggested += value; }
            remove { CommandManager.RequerySuggested -= value; }
        }

        public void Execute(object parameter)
        {
            var receita = m_ViewModel.Receita;

            m_ViewModel.Nome = receita.Nome;
            m_ViewModel.ReceitaTxt = receita.ReceitaTxt;
            m_ViewModel.Estilos = receita.IdEstilos;
            m_ViewModel.IdReceita = receita.IdReceita;
            m_ViewModel.Receita = null;
        }
    }
}
