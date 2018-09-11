using Receita01.Model;
using Receita01.ViewModel;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Receita01.Repositorio
{
    public class ReceitaRepository
    {
        private ReceitasDeCervejaViewModel m_ViewModel;

        public ReceitaRepository (ReceitasDeCervejaViewModel viewModel)
        {
            m_ViewModel = viewModel;
        }

        public void Insert (ReceitaDeCerveja entity)
        {
            ObservableCollection<ReceitaDeCerveja> list = m_ViewModel.ListReceitasDeCerveja;
            list.Add(entity);
            m_ViewModel.ListReceitasDeCerveja = list;
        }

        public void Delete (ReceitaDeCerveja entity)
        {
            ObservableCollection<ReceitaDeCerveja> list = m_ViewModel.ListReceitasDeCerveja;
            list.Remove(entity);
            m_ViewModel.ListReceitasDeCerveja = list;
        }

        public void Update (ReceitaDeCerveja entity)
        {
            ObservableCollection<ReceitaDeCerveja> list = m_ViewModel.ListReceitasDeCerveja;
            ReceitaDeCerveja receita = m_ViewModel.ListReceitasDeCerveja.FirstOrDefault(x => x.IdReceita == entity.IdReceita);
            list.Remove(receita);
            list.Add(entity);
            m_ViewModel.ListReceitasDeCerveja = list;
        }

    }
}
