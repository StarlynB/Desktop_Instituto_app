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
    public partial class profesores : Form
    {
        public profesores()
        {
            InitializeComponent();
        }

        private void profesores_Load(object sender, EventArgs e)
        {
            refrescar();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        #region
            private void refrescar()
            {
                using (taller_informaticaEntities5 db = new taller_informaticaEntities5())
                {
                var listaProf = from d in db.profesores
                                select d;

                    dataGridViewProf.DataSource = listaProf.ToList();
                }
            }
        #endregion

        private int? GetId()
        {
            try
            {
                return int.Parse(dataGridViewProf.Rows[dataGridViewProf.CurrentRow.Index].Cells[0].Value.ToString());
            }
            catch
            {
                return null;
            }
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            profesoresfrm addProfesores = new profesoresfrm();
            addProfesores.ShowDialog();

            refrescar();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            int? id = GetId();
            if(id != null)
            {
                profesoresfrm actProfesores= new profesoresfrm(id);
                actProfesores.ShowDialog();

                refrescar();


            }
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            int? id = GetId();
            if (id != null)
            {
                using (taller_informaticaEntities5 db = new taller_informaticaEntities5())
                {
                    profesore delteProfesores = db.profesores.Find(id);
                    db.profesores.Remove(delteProfesores);

                    db.SaveChanges();

                }

                refrescar();
            }
        }
    }
}
