namespace Interfaces_Practica_1
{
    public partial class Form1 : Form
    {
        private List<Usuario> usuarios;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            usuarios = new List<Usuario> {
            new Usuario { Nombre = "Dusan Kegler", Clave = "123", Mail = "dusanandreskegler@yahoo.com" },
            new Usuario { Nombre = "Andres Meliga", Clave = "456", Mail = "andresmeliga@ciudad.com.ar" }
            };

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            string usuarioIngresado = usuarioTxt.Text;
            string contraseñaIngresada = claveTxt.Text;

            var usuario = usuarios.FirstOrDefault(u =>
                u.Nombre == usuarioIngresado && u.Clave == contraseñaIngresada);

            if (usuario != null)
            {
                // Oculta el login y abre el form principal
                this.Hide();
                var formPrincipal = new Form2(usuario); // pasamos el usuario logueado
                formPrincipal.Show();
            }
            else
            {
                mensajeTxt.Text = "Usuario o contraseña incorrectos.";
                mensajeTxt.ForeColor = Color.Red;
            }
        }
    }
}
