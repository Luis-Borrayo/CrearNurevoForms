namespace CrearNurevoForms
{
    public partial class FormularioPrincipal : Form
    {
        public FormularioPrincipal()
        {
            InitializeComponent();
            this.IsMdiContainer = true;
        }

        private void btnAbrirFormulario_Click(object sender, EventArgs e)
        {
            Form FormsNuevo = new Nuevo_Formulario();
            FormsNuevo.Show();
        }

        private void FormularioPrincipal_Load(object sender, EventArgs e)
        {

        }
    }
}
