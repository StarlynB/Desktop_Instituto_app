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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
 

        }
        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_entrar_Click(object sender, EventArgs e)
        {
           

            
        }

        private void btn_Salir_Click(object sender, EventArgs e)
        {
            
            
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void txtContrasena_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void txtUsuario_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_entrar_Click_1(object sender, EventArgs e)
        {

        }

        private void panel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            addLoginUser loginUser = new addLoginUser();
            loginUser.ShowDialog();
        }

        private void btn_entrar_Click_2(object sender, EventArgs e)
        {
            string sPass = (txtContrasena.Text.Trim());

            using (taller_informaticaEntities5 db = new taller_informaticaEntities5())
            {
                var lst = from d in db.loginUsuarios
                          where d.email == txtUsuario.Text
                          && d.password == sPass
                          select d;

                if (lst.Count() > 0)
                {
                    MessageBox.Show("Usuarios existe" +
                        "\nBienvenido...");
                    Administracion_Users administracion_ = new Administracion_Users();
                    this.Hide();
                    administracion_.Show();
                }
                else
                {
                    MessageBox.Show("Usuario no exite" +
                        "\nIntente de nuevo!!");

                    txtUsuario.Text = "";
                    txtContrasena.Text = "";
                    Focus();

                }
            }
        }

        private void btn_Salir_Click_1(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseas salir? ", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void txtUsuario_TextChanged_1(object sender, EventArgs e)
        {

        }
    }
}
