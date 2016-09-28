using Business;
using Model;
using System.Windows;
using MainWindow;


namespace MainWindow
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        private ContatoBusiness _contatoBusiness;

        public MainWindow()
        {
            InitializeComponent();

            var _contatoBusiness = new ContatoBusiness();
            CarregaContatos();

        }

        public ContatoBusiness ContatoBusiness
        {
            get
            {
                return _contatoBusiness;
            }

            set
            {
                _contatoBusiness = value;
            }
        }

        public void CarregaContatos()
        {
            try
            {
                dataGrid.ItemsSource = ContatoBusiness.GetAll();
            }
            catch (System.Exception)
            {

                throw;
            }


        }

        public void CarregaSexo()
        {
            try
            {
                comboSexo.ItemsSource = _sexoBusiness.GetAll();
                comboSexo.ItemsSource

            }
            catch (System.Exception)
            {

                throw;
            }





        }
        private void dataGrid_SelectionChanged(object sender, System.Windows.Controls.SelectionChangedEventArgs e)
        {

            var contato = (ContatoModel) dataGrid.SelectedItem;

            txtNome.Text = contato.Nome;
            txtEmail.txt = contato.Email;
            txtTelefone.txt = contato.Telefone;
            txtData.txt = contato.DataNascimento;
            txtSexo.txt = contato.Sexo.Sexo;
               

        }
    }
    }

