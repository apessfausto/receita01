using Receita01.Repositorio;
using Receita01.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Receita01.Comandos
{
    public class DeletarReceitaCommand : ICommand
    {
        private ReceitasDeCervejaViewModel m_ViewModel;

        public DeletarReceitaCommand(ReceitasDeCervejaViewModel viewModel)
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

        public void Execute (object parameter)
        {
            var receita = m_ViewModel.Receita;
            var receitaRepository = new ReceitaRepository(m_ViewModel);

            receitaRepository.Delete(receita);

            m_ViewModel.Nome = string.Empty;
            m_ViewModel.ReceitaTxt = string.Empty;
            m_ViewModel.Estilo = null;
            m_ViewModel.IdReceita = 0;
        }
    }
}
