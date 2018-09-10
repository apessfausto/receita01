using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Receita01.Model
{
    /// <summary>
    /// Criação da classe Receita e notificação de alretação
    /// da propriedade.
    /// </summary>
    public class ReceitaDeCerveja : INotifyPropertyChanged
    {
        public ReceitaDeCerveja()
        {

        }

        private int _idReceita;

        public int IdReceita
        {
            get { return _idReceita; }
            set
            {
                if (value != _idReceita)
                {
                    _idReceita = value;
                    this.NotfyPropertyChanged("IdReceita");
                }
            }
        }

        private Estilos _idEstilos;

        public Estilos IdEstilos
        {
            get { return this._idEstilos; }
            set
            {
                if (value != _idEstilos)
                {
                    this._idEstilos = value;
                    this.NotfyPropertyChanged("IdEstilos");
                }
            }
        }

        private string _nome;

        public string Nome
        {
            get { return this._nome; }
            set
            {
                if (value != _nome)
                {
                    this._nome = value;
                    this.NotfyPropertyChanged("Nome");
                }
            }
        }

        private string _receitaTxt;

        public string ReceitaTxt
        {
            get { return this._receitaTxt; }
            set
            {
                if(value  != _receitaTxt)
                {
                    _receitaTxt = value;
                    this.NotfyPropertyChanged("ReceitaTxt");
                }
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        private void NotfyPropertyChanged(string propertyName)
        {
            if (this.PropertyChanged != null)
                this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }

    }
}
