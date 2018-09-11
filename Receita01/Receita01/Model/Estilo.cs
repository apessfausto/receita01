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
    public class Estilo
    {


        public Estilo(int idEstilo, string nome)
        {
            _idEstilo = idEstilo;
            _nome = nome;
        }




        private int _idEstilo;
        public int IdEstilo
        {
            get { return this._idEstilo; }
            set
            {
                if (value != _idEstilo)
                {
                    this._idEstilo = value;
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
