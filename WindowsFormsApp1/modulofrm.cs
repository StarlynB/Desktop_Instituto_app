using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Model;

namespace WindowsFormsApp1
{
    public partial class modulofrm : Form
    {

        public int? id;
        modulo Omodulo = null;
        public modulofrm(int? id = null)
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



        //Actualizar
        private void CargarDatos()
        {
            using (taller_informaticaEntities5 db = new taller_informaticaEntities5())
            {
                Omodulo = db.modulos.Find(id);
                txtCOdigo.Text = Convert.ToString(Omodulo.cod_modulo);
                txtNombre.Text = Omodulo.nombre;
                dtpFechaDeIngreso.Value = Convert.ToDateTime(Omodulo.fecha_ingreso);
                dtpFechaDeCierre.Value = Convert.ToDateTime(Omodulo.fecha_cierre);
                txtHoras.Text = Convert.ToString(Omodulo.modulos_horas);

            }
        }

        private void modulofrm_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (validarForm(this, errorProvider1) == false)
            {
                using (taller_informaticaEntities5 db = new taller_informaticaEntities5())
                {
                    if (id == null)
                        Omodulo = new modulo();
                    Omodulo.cod_modulo = Convert.ToInt16(txtCOdigo.Text);
                    Omodulo.nombre = txtNombre.Text;
                    Omodulo.fecha_ingreso = dtpFechaDeIngreso.Value;
                    Omodulo.fecha_cierre = dtpFechaDeCierre.Value;
                    Omodulo.modulos_horas = Convert.ToInt16(txtCOdigo.Text);

                    //si el id esta vacio guardame los datos llenados
                    if (id == null)

                        db.modulos.Add(Omodulo);

                    //de lo contrario actualizame los datos
                    else
                    {
                        db.Entry(Omodulo).State = System.Data.Entity.EntityState.Modified;
                    }
                    db.SaveChanges();

                    this.Close();
                }
            }
        }

        private void modulofrm_FormClosed(object sender, FormClosedEventArgs e)
        {
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
