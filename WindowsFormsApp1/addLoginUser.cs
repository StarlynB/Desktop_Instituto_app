using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Model;

namespace WindowsFormsApp1
{
    public partial class addLoginUser : Form
    {
        public addLoginUser()
        {
            InitializeComponent();
        }

        private void btnADDloginUser_Click(object sender, EventArgs e)
        {
            using (taller_informaticaEntities5 db = new taller_informaticaEntities5())
            {
                loginUsuario login = new loginUsuario();
                login.email = txtADDemail.Text;
                login.password = txtADDpassword.Text;

                db.loginUsuarios.Add(login);

                
                MessageBox.Show("Usuario registrado Exitosamente" , "guardado");
                db.SaveChanges();
            }
        }

        private void btnSalirADDlogin_Click(object sender, EventArgs e)
        {
            Form1 login = new Form1();
            login.Show();
            this.Close();
        }

        private void addLoginUser_Load(object sender, EventArgs e)
        {

        }
    }
}
