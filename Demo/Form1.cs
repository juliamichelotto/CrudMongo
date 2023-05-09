namespace Demo
{
    public partial class Form1 : Form
    {
        private Repositorio repositorio;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            repositorio = new Repositorio();
            bsAgenda.DataSource = repositorio;
            bsAgenda.ResetBindings(false);
            List<Agenda> lista = repositorio.ListaAgenda;

        }
    }
}