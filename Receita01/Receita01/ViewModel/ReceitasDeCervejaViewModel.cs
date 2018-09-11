using Receita01.Comandos;
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

        private ObservableCollection<Estilo> _listEstilos;


        public ObservableCollection<Estilo> ListEstilos
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

        private Estilo _estilo;

        public Estilo Estilo
        {
            get { return _estilo; }
            set
            {
                if(value != _estilo)
                {
                    _estilo = value;
                    this.NotfyPropertyChanged("Estilo");
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
        public ICommand CancelarEdicaoCommand { get; set; }


        private void Initialize()
        {
            this.SalvarReceitaCommand = new SalvarReceitaCommand(this);
            this.DeletarReceitaCommand = new DeletarReceitaCommand(this);
            this.CarregarReceitaCommand = new CarregarReceitaCommand(this);
            this.CancelarEdicaoCommand = new CancelarEdicaoCommand(this);

            this._listReceitasDeCerveja = new ObservableCollection<ReceitaDeCerveja>();
            this._listEstilos = new ObservableCollection<Estilo>();

            //Lista de Estilo

            _listEstilos.Add(new Estilo(1, "Pale Ale"));
            _listEstilos.Add(new Estilo(2, "Weiss"));
            _listEstilos.Add(new Estilo(3, "IPA"));
            _listEstilos.Add(new Estilo(4, "APA"));
            _listEstilos.Add(new Estilo(5, "Stout"));
            _listEstilos.Add(new Estilo(6, "Porter"));
            _listEstilos.Add(new Estilo(7, "Sour"));
            _listEstilos.Add(new Estilo(8, "Pilsner"));
            _listEstilos.Add(new Estilo(9, "Trappist"));
            _listEstilos.Add(new Estilo(10, "Witbier"));
            _listEstilos.Add(new Estilo(11, "Irish Red Ale"));


        }

        public event PropertyChangedEventHandler PropertyChanged;

        private void NotfyPropertyChanged(string propertyName)
        {
            if (this.PropertyChanged != null)
                this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }

    }
}
