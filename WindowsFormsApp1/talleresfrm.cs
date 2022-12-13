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
    public partial class talleresfrm : Form
    {
        public int? id;
        tallere oTalleres = null;
        public talleresfrm(int? id = null)
        {
            InitializeComponent();

            this.id = id;
            if (id != null)
                CargarDatos();
        }

        public static Boolean validarForm(Control objecto, ErrorProvider errorProvider1)
        {
            Boolean hayErrores = false;

            foreach (Control item in objecto.Controls)
            {
                if (item is ErrorProvide)
                {
                    ErrorProvide obj = (ErrorProvide)item;

                    if (obj.validar == true)
                    {
                        if (string.IsNullOrEmpty(obj.Text.Trim()))
                        {
                            errorProvider1.SetError(obj, "No puede estar vacia");
                            hayErrores = true;
                        }
                    }
                    else
                    {
                        errorProvider1.SetError(obj, "");
                    }
                }
            }

            return hayErrores;
        }

        private void CargarDatos()
        {
            using (taller_informaticaEntities5 db = new taller_informaticaEntities5()) {
                oTalleres = new tallere();
                oTalleres = db.talleres.Find(id);
                txtNombre.Text = Convert.ToString(oTalleres.nombre);
                txtUbicacion.Text = Convert.ToString(oTalleres.ubicacion);
            }
        }


        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (validarForm(this, errorProvider1) == false)
            {
                using (taller_informaticaEntities5 db = new taller_informaticaEntities5())
                {
                    if (id == null)
                        oTalleres = new tallere();
                    oTalleres.nombre = txtNombre.Text;
                    oTalleres.ubicacion = txtUbicacion.Text;
                    if (id == null)
                        db.talleres.Add(oTalleres);
                    else
                    {
                        db.Entry(oTalleres).State = System.Data.Entity.EntityState.Modified;
                    }

                    db.SaveChanges();
                    this.Close();
                }

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void talleresfrm_Load(object sender, EventArgs e)
        {

        }
    }
}
