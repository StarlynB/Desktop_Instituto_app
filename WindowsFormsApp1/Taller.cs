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
    public partial class Taller : Form
    {
        public Taller()
        {
            InitializeComponent();
        }

       

        private void Taller_Load(object sender, EventArgs e)
        {
            //data read
            refrescar();
        }


        //encapsulamiento
        #region Helper
        //lista de talleres
        private void refrescar()
        {
            using (taller_informaticaEntities5 db = new taller_informaticaEntities5())
            {
                var ListaTalleres = from d in db.talleres
                                    select d;
                dataGridViewTalleres.DataSource = ListaTalleres.ToList();
            }
        }
        #endregion



        private int? GetId()
        {
            try
            {
                return int.Parse(dataGridViewTalleres.Rows[dataGridViewTalleres.CurrentRow.Index].Cells[0].Value.ToString());
            }
            catch
            {
                return null;
            }

        }


        //insert
        private void btn_Insert_Click(object sender, EventArgs e)
        {
            talleresfrm aggtelleres = new talleresfrm();
            aggtelleres.ShowDialog();

            refrescar();
        }

        //update

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            int? id = GetId();
            if(id != null)
            {
                talleresfrm actulizarTalleres = new talleresfrm(id);
                actulizarTalleres.ShowDialog();
                MessageBox.Show("Usuario actulizado!👌");

                refrescar();    

            }
        }


        //delete
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            int? id = GetId();
            if (id != null)
            {
                using (taller_informaticaEntities5 db = new taller_informaticaEntities5())
                {
                    tallere Deletetalleres = db.talleres.Find(id);
                    MessageBox.Show("Deseas eliminar? ♻️");
                    db.talleres.Remove(Deletetalleres);

                    db.SaveChanges();
                }
                
                refrescar();    

            }
        }

        private void Taller_FormClosed(object sender, FormClosedEventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridViewTalleres_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
