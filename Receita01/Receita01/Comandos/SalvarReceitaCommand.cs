using Receita01.Model;
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
    public class SalvarReceitaCommand : ICommand
    {
        private ReceitasDeCervejaViewModel m_ViewModel;

        public SalvarReceitaCommand (ReceitasDeCervejaViewModel viewModel)
        {
            m_ViewModel = viewModel;
        }

        public bool CanExecute(object parameter)
        {
            if (!string.IsNullOrEmpty(m_ViewModel.Nome) && !string.IsNullOrEmpty(m_ViewModel.ReceitaTxt) && m_ViewModel.Estilo != null)
                return true;
            else
                return false;           
        }

        public event EventHandler CanExecuteChanged
        {
            add { CommandManager.RequerySuggested += value; }
            remove { CommandManager.RequerySuggested -= value; }
        }

        public void Execute (object parameter)
        {
            var receita = new ReceitaDeCerveja();
            receita.Nome = m_ViewModel.Nome;
            receita.ReceitaTxt = m_ViewModel.ReceitaTxt;
            receita.IdEstilo = m_ViewModel.Estilo;

            var receitaRepository = new ReceitaRepository(m_ViewModel);

            if (m_ViewModel.IdReceita == 0)
            {
                receita.IdReceita = m_ViewModel.ListReceitasDeCerveja.Count + 1;
                receitaRepository.Insert(receita);
            }
            else
            {
                receita.IdReceita = m_ViewModel.IdReceita;
                receitaRepository.Update(receita);
            }

            m_ViewModel.IdReceita = 0;
            m_ViewModel.Nome = string.Empty;
            m_ViewModel.ReceitaTxt = string.Empty;
            m_ViewModel.Estilo = null;
        }
    }
}
