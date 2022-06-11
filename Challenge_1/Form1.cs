using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Challenge_1
{
    public partial class Form1 : Form
    {
        List<UsuariosRegistrados> UsuariosList = new List<UsuariosRegistrados>();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            UsuariosRegistrados usuario1 = new UsuariosRegistrados("JoaquinGG", "123OPAla");
            UsuariosRegistrados usuario2 = new UsuariosRegistrados("JulianEA", "45963207Jv");
            UsuariosRegistrados usuario3 = new UsuariosRegistrados("Mauro123", "eX234&Jl");

            UsuariosList.Add(usuario1);
            UsuariosList.Add(usuario2);
            UsuariosList.Add(usuario3);
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            var usuarios = UsuariosList;
            string username = inputName.Text;
            string pwd = inputPassword.Text;
            UsuariosRegistrados asd = usuarios.Find(item => item.usuario == username && item.contraseña == pwd);
            if (asd != null)
            {
                Result MessageWindow = new Result("Exito");
                MessageWindow.Show();
            } else {
                Result MessageWindow = new Result("Fallo");
                MessageWindow.Show();
            };
        }
    }
}
