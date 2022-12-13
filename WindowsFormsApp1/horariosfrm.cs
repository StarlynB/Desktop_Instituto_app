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
    public partial class tetDias : Form
    {
        public int? id;
        horario oHorario = null;
        public tetDias(int? id = null)
        {
            InitializeComponent();


            this.id = id;
            if (id != null)
                cargarDatos();
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

        public void cargarDatos()
        {
            using (taller_informaticaEntities5 db = new taller_informaticaEntities5() ) {
                oHorario = db.horarios.Find(id);
                txtTanda.Text = oHorario.tanda;
                tesDias.Text = Convert.ToString(oHorario.dias);
                textHoras.Text = Convert.ToString(oHorario.Horas);

            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (validarForm(this, errorProvider1) == false)
            {

                using (taller_informaticaEntities5 db = new taller_informaticaEntities5())
                {
                    if (id == null)
                        oHorario = new horario();
                    oHorario.tanda = txtTanda.Text;
                    oHorario.dias = Convert.ToInt16(tesDias.Text);
                    oHorario.Horas = Convert.ToInt16(textHoras.Text);
                    if (id == null)
                        db.horarios.Add(oHorario);
                    else
                    {
                        db.Entry(oHorario).State = System.Data.Entity.EntityState.Modified;
                    }

                    db.SaveChanges();
                    this.Close();
                }
            }
        }

        private void horariosfrm_FormClosed(object sender, FormClosedEventArgs e)
        {
           
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void horariosfrm_Load(object sender, EventArgs e)
        {

        }
    }
}
