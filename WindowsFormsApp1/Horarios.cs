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
    public partial class Horarios : Form
    {
        public Horarios()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }


        #region Helper

        private void refrescar()
        {
            using (taller_informaticaEntities5 db = new taller_informaticaEntities5())
            {
                var lista_horarios = from d in db.horarios
                                 select d;
                dataGridViewHorarios.DataSource = lista_horarios.ToList();
            }

        }

        #endregion

        private void Horarios_Load(object sender, EventArgs e)
        {
            refrescar();
        }

        public int? GetId()
        {
            try
            {
                return int.Parse(dataGridViewHorarios.Rows[dataGridViewHorarios.CurrentRow.Index].Cells[0].Value.ToString());
            }

            catch 
            {
                return null;
            }
        }

        //insertar
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            tetDias addhorario = new tetDias();
            addhorario.ShowDialog();

            refrescar();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            int? id = GetId();
            if (id != null)
            {
                tetDias Acthorario = new tetDias(id);
                Acthorario.ShowDialog();

                refrescar();
            }
        }

        private void btnElminar_Click(object sender, EventArgs e)
        {
            int? id = GetId();
            if (id != null)
            {
                using (taller_informaticaEntities5 db = new taller_informaticaEntities5())
                {
                    horario DeleteHorario = db.horarios.Find(id);
                    db.horarios.Remove(DeleteHorario);

                    db.SaveChanges();
                }

                refrescar();
            }
        }

        private void Horarios_FormClosed(object sender, FormClosedEventArgs e)
        {
            //Application.Exit();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
