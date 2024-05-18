using System.ComponentModel.DataAnnotations;
using WinFormsApp;

namespace WinFormsApp
{
    public partial class Form1 : Form
    {
        private UsuarioContext _context;
        public Form1()
        {
            InitializeComponent();
            // instanciei um objeto do contexto
            _context = new UsuarioContext();
            // garantir que a base de dados sera criada
            _context.Database.EnsureCreated();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            var nome = txtBoxNome.Text;
            var email = txtBoxEmail.Text;
            var senha = txtBoxSenha.Text;
            // criar um usuario
            var usuario = new Usuario{ 
                Email = email,
                Nome = nome,
                Senha = senha
                };
            // adicionar o usuario no contexto do banco
            _context.Usuarios.Add(usuario);
            //salvar as alterações no contexto
            _context.SaveChanges();

            //limpar campos
            limpar_Campos();
        }

        private void limpar_Campos()
        {
            txtBoxEmail.Text = string.Empty;
            txtBoxNome.Text = string.Empty;
            txtBoxSenha.Text = string.Empty;

            txtBoxNome.Focus();
        }
    }
}
