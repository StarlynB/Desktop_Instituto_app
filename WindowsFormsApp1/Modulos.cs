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
    public partial class Modulos : Form
    {
        
        public Modulos() 
        {
            InitializeComponent();
        }

       

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Modulos_Load(object sender, EventArgs e)
        {
            refrescar();
        }


        //Esto es encapsulamiento
        #region HElPER
        private void refrescar()
        {
            //select SQL
            using (taller_informaticaEntities5 db = new taller_informaticaEntities5())
            {
                var listaModulos = from d in db.modulos
                                   select d;
                dataGridViewModulos.DataSource = listaModulos.ToList();
            }
        }
        #endregion


        
        

        private int? GetId()
        {
            try
            {
                return int.Parse(dataGridViewModulos.Rows[dataGridViewModulos.CurrentRow.Index].Cells[0].Value.ToString());
            }
            catch
            {
                return null;
            }
        }


        //insertar
        private void btn_Insert_Click_1(object sender, EventArgs e)
        {
            modulofrm aggmodulo = new modulofrm();
            aggmodulo.ShowDialog();

            refrescar();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            int? id = GetId();
            if(id != null){
                modulofrm Actmodulo = new modulofrm(id);
                Actmodulo.ShowDialog();

                refrescar();
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            int? id = GetId();
            if (id != null)
            {
                using (taller_informaticaEntities5 db = new taller_informaticaEntities5())
                {
                    modulo deletemodulo = db.modulos.Find(id);
                    db.modulos.Remove(deletemodulo);

                    db.SaveChanges();
                }

                refrescar();
            }
        }

        private void Modulos_FormClosed(object sender, FormClosedEventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridViewModulos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
