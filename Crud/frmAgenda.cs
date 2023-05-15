using DAL;
namespace Crud
{
    public partial class frmAgenda : Form
    {
        private Repositorio repositorio;
        public frmAgenda()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            repositorio = new Repositorio();
            bsAgenda.DataSource = repositorio;


        }
    }
}