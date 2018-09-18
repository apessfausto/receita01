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
        public int salvarR(tb_receitas receita)
        {
            using (FAUSTO_DBEntities cntx = new FAUSTO_DBEntities())
            {
                cntx.tb_receitas.Add(receita);
                return cntx.SaveChanges();

            }
        }

        public int delete(tb_receitas receita)
        {
            using (FAUSTO_DBEntities cntx = new FAUSTO_DBEntities())
            {
                cntx.tb_receitas.Remove(receita);
                return cntx.SaveChanges();

            }
        }
    }
}
