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
    public partial class Curso : Form
    {
        public Curso()
        {
            InitializeComponent();
        }

        private void Curso_Load(object sender, EventArgs e)
        {
            refrescar();
        }


        #region HELPER

        private void refrescar()
        {
            using (taller_informaticaEntities5 db = new taller_informaticaEntities5())
            {
                var lista_curso = from d in db.cursos
                                  select d;
                dataGridCursos.DataSource = lista_curso.ToList();
            }
        }

        #endregion

        public int? GetId()
        {
            try
            {
                return int.Parse(dataGridCursos.Rows[dataGridCursos.CurrentRow.Index].Cells[0].Value.ToString());
            }
            catch
            {
                return null;
            }
        }



        private void btnAgregar_Click(object sender, EventArgs e)
        {
           cursosfrm addCurso = new cursosfrm();
            addCurso.ShowDialog();

            refrescar();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            int? id = GetId();
            if(id != null)
            {
                cursosfrm actCurso= new cursosfrm(id);
                actCurso.ShowDialog();

                refrescar();
            }
            else
            {
                MessageBox.Show("No exite estudiante aun!");
            }
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            int? id = GetId();
            if(id !=  null)
            {
                using (taller_informaticaEntities5 db = new taller_informaticaEntities5())
                {
                    curso deleteCurso = db.cursos.Find(id);
                    db.cursos.Remove(deleteCurso);

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
