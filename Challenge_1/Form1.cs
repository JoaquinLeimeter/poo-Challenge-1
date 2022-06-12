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
            //En lugar de darles esas contraseñas, pueden encriptar y pasarle
            //eso al constructor de ususarios registrados usando esta lista como nuestra BD.
            //puntos extra si usan una BD
            UsuariosRegistrados usuario1 = new UsuariosRegistrados("Joaquin", "123");
            UsuariosRegistrados usuario2 = new UsuariosRegistrados("JulianEA", "45963207Jv");
            UsuariosRegistrados usuario3 = new UsuariosRegistrados("Mauro123", "eX234&Jl");

            UsuariosList.Add(usuario1);
            UsuariosList.Add(usuario2);
            UsuariosList.Add(usuario3);
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            //prestar atención a la validación para encontrar usuarios.
            var usuarios = UsuariosList;
            string usuario = inputName.Text;
            string contraseña = inputPassword.Text;
            //acá hay que comparar la contraseña encriptada.
            UsuariosRegistrados u = usuarios.Find(item => item.usuario == usuario && item.contraseña == contraseña);
            if (u != null)
            {
                MessageBox.Show("Exito");
            } else {
                MessageBox.Show("Datos incorrectos");

            };
        }
    }
}
