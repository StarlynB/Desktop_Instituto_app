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
    public partial class Administracion_Users : Form
    {
        public Administracion_Users()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Estudiantes estudiantes= new Estudiantes();
            estudiantes.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Modulos modulos= new Modulos();
            modulos.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Taller taller = new Taller();
            taller.ShowDialog();
        }

        private void btnHorarios_Click(object sender, EventArgs e)
        {
            Horarios horarios = new Horarios();
            horarios.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form1 login = new Form1();
            this.Hide();
            login.ShowDialog();
        }

        private void Administracion_Users_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Curso curso = new Curso();
            curso.ShowDialog();
        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            profesores profesores = new profesores();
            profesores.ShowDialog();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel7_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Administracion_Users_Load(object sender, EventArgs e)
        {

        }
    }
}
