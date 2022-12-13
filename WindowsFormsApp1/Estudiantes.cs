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
    public partial class Estudiantes : Form
    {
        public Estudiantes()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }


        #region HELPER
        private void refrescar()
        {
            using (taller_informaticaEntities5 db = new taller_informaticaEntities5())
            {
                var listaEst = from d in db.estudiantes
                               select d;

                dataGridEst.DataSource = listaEst.ToList();
            }

        }
        #endregion

        private void Estudiantes_Load(object sender, EventArgs e)
        {
            refrescar();
        }


        public int? GetId()
        {
            try
            {
                return int.Parse(dataGridEst.Rows[dataGridEst.CurrentRow.Index].Cells[0].Value.ToString());
            }
            catch
            { return null; }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            estudiantesfrm addEst = new estudiantesfrm();
            addEst.ShowDialog();

            refrescar();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            int? id = GetId();
            if(id != null)
            {
                estudiantesfrm actEst = new estudiantesfrm(id);
                actEst.ShowDialog();

                refrescar();

            }
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            int? id = GetId();
            if(id != null)
            {
                using(taller_informaticaEntities5 db = new taller_informaticaEntities5())
                {
                    estudiante deleteEst = db.estudiantes.Find(id);
                    db.estudiantes.Remove(deleteEst);
                    db.SaveChanges();

                    
                }
                refrescar();
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
