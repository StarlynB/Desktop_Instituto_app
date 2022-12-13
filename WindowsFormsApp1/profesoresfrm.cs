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
    public partial class profesoresfrm : Form
    {
        public int? id;
        profesore oProfesores = null;
        public profesoresfrm(int? id = null)
        {
            InitializeComponent();

            this.id = id;
            if(id != null)
            {
                cargaDatos();
            }
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


        private void cargaDatos() 
        {
            using(taller_informaticaEntities5 db = new taller_informaticaEntities5())
            {
                oProfesores = db.profesores.Find(id);
                txtNombre.Text = oProfesores.nombre;
                txtApellifo.Text = oProfesores.apellido;
                txtSexo.Text = oProfesores.sexo;
                dateTimeNacim.Value = Convert.ToDateTime( oProfesores.fecha_nacimiento);
                txtCedula.Text = Convert.ToString( oProfesores.cedula);
                txtNacionalidad.Text = oProfesores.nacionalidad;
                txtDireccion.Text = oProfesores.direccion;
                txtTel.Text = oProfesores.telefono;
                txtEmail.Text = oProfesores.email;
                dateTimeIngreso.Value = Convert.ToDateTime(oProfesores.fecha_ingreso);
                txtSangre.Text = oProfesores.tipo_sangre;
                txtGrado.Text = oProfesores.grado;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (validarForm(this, errorProvider1) == false)
            {
                using (taller_informaticaEntities5 db = new taller_informaticaEntities5())
                {
                    if (id == null)
                        oProfesores = new profesore();
                    oProfesores.nombre = txtNombre.Text;
                    oProfesores.apellido = txtApellifo.Text;
                    oProfesores.sexo = txtSexo.Text;
                    oProfesores.fecha_nacimiento = Convert.ToDateTime(dateTimeNacim.Value);
                    oProfesores.cedula = Convert.ToInt32(txtCedula.Text);
                    oProfesores.nacionalidad = txtNacionalidad.Text;
                    oProfesores.direccion = txtDireccion.Text;
                    oProfesores.telefono = txtTel.Text;
                    oProfesores.email = txtEmail.Text;
                    oProfesores.fecha_ingreso = Convert.ToDateTime(dateTimeIngreso.Value);
                    oProfesores.tipo_sangre = txtSangre.Text;
                    oProfesores.grado = txtGrado.Text;
                    oProfesores.estado = txtEstado.Text;


                    if (id == null)
                        db.profesores.Add(oProfesores);
                    else
                    {
                        db.Entry(oProfesores).State = System.Data.Entity.EntityState.Modified;
                    }
                    db.SaveChanges();
                    this.Close();
                }
            }
        }

        private void profesoresfrm_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void errorProvide1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
