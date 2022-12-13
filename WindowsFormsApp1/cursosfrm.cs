using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Model;

namespace WindowsFormsApp1
{
    public partial class cursosfrm : Form
    {
        public int? id;
        curso oCurso = null;

        public cursosfrm(int? id = null)
        {
            InitializeComponent();

            this.id = id;
            if (id != null)
                cargarDatos();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void cargarDatos()
        {
            using (taller_informaticaEntities5 db = new taller_informaticaEntities5())
            {
                oCurso = db.cursos.Find(id);
                txtNombreCurso.Text = oCurso.nombre;
                txtCodigo.Text = Convert.ToString(oCurso.cod_curso);
                dateTimeInicio.Value = Convert.ToDateTime(oCurso.fecha_inicio);
                dateTimeCierre.Value = Convert.ToDateTime(oCurso.fecha_cierre);
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

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (validarForm(this, errorProvider1) == false)
            {
                using (taller_informaticaEntities5 db = new taller_informaticaEntities5())
                {
                    if (id == null)
                        oCurso = new curso();
                    oCurso.nombre = txtNombreCurso.Text;
                    oCurso.cod_curso = Convert.ToInt16(txtCodigo.Text);
                    oCurso.fecha_inicio = dateTimeInicio.Value;
                    oCurso.fecha_cierre = dateTimeCierre.Value;

                    if (id == null)
                        db.cursos.Add(oCurso);

                    else
                    {
                        db.Entry(oCurso).State = System.Data.Entity.EntityState.Modified;
                    }

                    db.SaveChanges();

                    this.Close();

                }
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cursosfrm_Load(object sender, EventArgs e)
        {

        }
    }
}
