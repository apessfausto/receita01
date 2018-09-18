using Mvvm.Commands;
using Receita01.Model;
using Receita01.Repositorio;
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
        //prpriedade para chamar os metodos da Repositpry
        private readonly ReceitaRepository receitaR;

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


        private ReceitaDeCerveja _receita;

        public ReceitaDeCerveja Receita
        {
            get { return _receita; }
            set
            {
                if (value != _receita)
                {
                    _receita = value;
                    this.NotfyPropertyChanged("Receita");
                }
            }
        }

        private string _estilo;

        public string Estilo
        {
            get { return _estilo; }
            set
            {
                if (value != _estilo)
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
                if (value != _idReceita)
                {
                    _idReceita = value;
                    this.NotfyPropertyChanged("IdReceita");
                }
            }
        }

        private string _nome;

        public String Nome
        {
            get { return this._nome; }
            set
            {
                if (value != _nome)
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
                if (value != _receitaTxt)
                {
                    _receitaTxt = value;
                    this.NotfyPropertyChanged("ReceitaTxt");
                }
            }
        }

        public ReceitasDeCervejaViewModel()
        {
            this.receitaR = new ReceitaRepository();
            this.Initialize();
        }

        public DelegateCommand SalvarReceitaCommand { get; set; }
        public DelegateCommand DeletarReceitaCommand { get; set; }
        public DelegateCommand CarregarReceitaCommand { get; set; }
        public DelegateCommand CancelarEdicaoCommand { get; set; }


        private void Initialize()
        {
            this.SalvarReceitaCommand = new DelegateCommand(salvar);
            this.DeletarReceitaCommand = new DelegateCommand(delete);

        }

        private void delete()
        {
            int result = receitaR.salvarR(new tb_receitas { nome_receita = Nome, estilo = Estilo, receita_text = ReceitaTxt });
        }

        private void salvar()
        {
            int result = receitaR.salvarR(new tb_receitas { nome_receita = Nome, estilo = Estilo, receita_text = ReceitaTxt });
        }

        public event PropertyChangedEventHandler PropertyChanged;

        private void NotfyPropertyChanged(string propertyName)
        {
            if (this.PropertyChanged != null)
                this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }

    }
}
