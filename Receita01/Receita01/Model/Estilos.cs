using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Receita01.Model
{
    /// <summary>
    /// Criação da classe que irá compor 
    /// os estilos de cerveja selecionados ao escrever a receita.
    /// </summary>
    public class Estilos
    {


        public Estilos(int idEstilos, string nome)
        {
            _idEstilos = idEstilos;
            _nome = nome;
        }




        private int _idEstilos;
        public int IdEstilos
        {
            get { return this._idEstilos; }
            set
            {
                if (value != _idEstilos)
                {
                    this._idEstilos = value;
                }
            }
        }

        private string _nome;

        public string NomeEstilo
        {
            get { return this._nome; }
            set
            {
                if (value != _nome)
                {
                    this._nome = value;
                }
            }
        }
     }


}
