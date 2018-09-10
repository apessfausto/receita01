using Receita01.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Receita01.ViewModel
{
    public class ReceitasDeCervejaViewModel : INotifyPropertyChanged
    {
        private ObservableCollection<ReceitaDeCerveja> _listReceitasDeCerveja;

        public ObservableCollection<ReceitaDeCerveja> ListReceitasDeCerveja
        {
            get { return _listReceitasDeCerveja; }
            set
            {
                _listReceitasDeCerveja = value;
                this.NotfyPropertyChanged("ReceitasDeCerveja");
            }
        }

        private ObservableCollection<Estilos> _listEstilos;


        public ObservableCollection<Estilos> ListEstilos
        {
            get { return _listEstilos; }
            set
            {
                _listEstilos = value;
                this.NotfyPropertyChanged("ListEstilos");
            }
        }

        private ReceitaDeCerveja _receita;

        public ReceitaDeCerveja Receita
        {
            get { return _receita; }
            set
            {
                if(value != _receita)
                {
                    _receita = value;
                    this.NotfyPropertyChanged("Receita");
                }
            }
        }

        private Estilos _estilos;

        public Estilos Estilos
        {
            get { return _estilos; }
            set
            {
                if(value != _estilos)
                {
                    _estilos = value;
                    this.NotfyPropertyChanged("Estilos");
                }
            }
        }

        private int _idReceita;

        public int IdReceita
        {
            get { return this._idReceita; }
            set
            {
                if(value != _idReceita)
                {
                    _idReceita = value;
                    this.NotfyPropertyChanged("IdReceita");
                }
            }
        }

        private string _nome;

        public String Nome
        {
            get {return this._nome; }
            set
            {
                if(value != _nome)
                {
                    _nome = value;
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
                if(value != _receitaTxt)
                {
                    _receitaTxt = value;
                    this.NotfyPropertyChanged("ReceitaTxt");
                }
            }
        }

        public ReceitasDeCervejaViewModel()
        {
            this.Initialize();
        }

        public ICommand SalvarReceitaCommand { get; set; }
        public ICommand DeletarReceitaCommand { get; set; }
        public ICommand CarregarReceitaCommand { get; set; }
        public ICommand CancelarEdicaoReceitaCommand { get; set; }


        private void Initialize()
        {
            this.SalvarReceitaCommand = new SalvarReceitaCommand(this);
            this.DeletarReceitaCommand = new DeletarReceitaCommand(this);
            this.CarregarReceitaCommand = new CarregarReceitaCommand(this);
            this.CancelarEdicaoReceitaCommand = new CancelarEdicaoReceitaCommand(this);

            this._listReceitasDeCerveja = new ObservableCollection<ReceitaDeCerveja>;
            this._listEstilos = new ObservableCollection<Estilos>;

            //Lista de Estilos

            _listEstilos.Add(new Estilos(1, "Pale Ale"));
            _listEstilos.Add(new Estilos(2, "Weiss"));
            _listEstilos.Add(new Estilos(3, "IPA"));
            _listEstilos.Add(new Estilos(4, "APA"));
            _listEstilos.Add(new Estilos(5, "Stout"));
            _listEstilos.Add(new Estilos(6, "Porter"));
            _listEstilos.Add(new Estilos(7, "Sour"));
            _listEstilos.Add(new Estilos(8, "Pilsner"));
            _listEstilos.Add(new Estilos(9, "Trappist"));
            _listEstilos.Add(new Estilos(10, "Witbier"));

        }

        public event PropertyChangedEventHandler PropertyChanged;

        private void NotfyPropertyChanged(string propertyName)
        {
            if (this.PropertyChanged != null)
                this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }

    }
}
