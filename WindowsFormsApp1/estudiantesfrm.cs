using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics.CodeAnalysis;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Model;

namespace WindowsFormsApp1
{
    public partial class estudiantesfrm : Form
    {
        public int? id;
        estudiante Oestudiantes;
        public estudiantesfrm(int? id = null)
        {
            InitializeComponent();

            this.id = id;
            if(id!= null ) 
               cargarDatos();
            
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            using (taller_informaticaEntities5 db = new taller_informaticaEntities5())
            {
                
            }
        }

        private void estudiantesfrm_Load(object sender, EventArgs e)
        {

        }


        private void cargarDatos()
        {
            using (taller_informaticaEntities5 db = new taller_informaticaEntities5())
            {
                Oestudiantes = db.estudiantes.Find(id);
                txtNombre.Text = Oestudiantes.nombre;
                txtApellido.Text= Oestudiantes.apellido;
                txtSexo.Text = Oestudiantes.sexo;
                dateTimeNaci.Value = Convert.ToDateTime( Oestudiantes.fecha_nacimiento);
                txtCedula.Text =Convert.ToString(Oestudiantes.cedula);
                txtDireccion.Text = Oestudiantes.direccion;
                txtTel.Text = Oestudiantes.telefono;
                txtEmail.Text= Oestudiantes.email;
                dateTimeIngreso.Value = Convert.ToDateTime(Oestudiantes.fecha_ingreso);
                txtSangre.Text = Oestudiantes.tipo_sangre;
                txtGrado.Text= Oestudiantes.grado;
                txtStatus.Text= Oestudiantes.status;
                txtStatus.Text = Oestudiantes.status;
                txtTallerID.Text = Convert.ToString( Oestudiantes.id_taller);
                txtCursoID.Text = Convert.ToString(Oestudiantes.id_curso);
                txtModuloID.Text = Convert.ToString(Oestudiantes.id_modulo);
               

            }
        }

        

        public static Boolean validarForm(Control objecto, ErrorProvider errorProvider1)
        {
            Boolean hayErrores = false;

            foreach(Control item in objecto.Controls)
            {
                if(item is ErrorProvide)
                {
                    ErrorProvide obj = (ErrorProvide)item;

                    if(obj.validar == true)
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
                        Oestudiantes = new estudiante();
                    Oestudiantes.nombre = txtNombre.Text;
                    Oestudiantes.apellido = txtApellido.Text;
                    Oestudiantes.sexo = txtSexo.Text;
                    Oestudiantes.fecha_nacimiento = dateTimeNaci.Value;
                    Oestudiantes.cedula = Convert.ToInt32(txtCedula.Text);
                    Oestudiantes.nacionalidad = txtNacionalida.Text;
                    Oestudiantes.direccion = txtDireccion.Text;
                    Oestudiantes.telefono = txtTel.Text;
                    Oestudiantes.email = txtEmail.Text;
                    Oestudiantes.fecha_ingreso = dateTimeIngreso.Value;
                    Oestudiantes.tipo_sangre = txtSangre.Text;
                    Oestudiantes.grado = txtGrado.Text;
                    Oestudiantes.status = txtStatus.Text;
                    Oestudiantes.id_taller = Convert.ToInt32(txtTallerID.Text);
                    Oestudiantes.id_curso = Convert.ToInt32(txtCursoID.Text);
                    Oestudiantes.id_modulo = Convert.ToInt32(txtModuloID.Text);
                    //Oestudiantes.foto = Convert.ToBoolean(ms.GetBuffer());

                    if (id == null)
                        db.estudiantes.Add(Oestudiantes);
                    else
                    {
                        db.Entry(Oestudiantes).State = System.Data.Entity.EntityState.Modified;
                    }

                    db.SaveChanges();

                    this.Close();
                }
            }


        }

        private void txtSexo_TextChanged(object sender, EventArgs e)
        {

        }

        //private void btbSaveImage_Click(object sender, EventArgs e)
        //{
        //    //configuaracion de lo visual cuando le demos a agregar
        //    OpenFileDialog ofImagen = new OpenFileDialog();
        //    ofImagen.Filter = "Imagenes | *jpg; *.png";
        //    ofImagen.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures);
        //    ofImagen.Title = "Seleccionar imagen"; 

        //    //con esto  agregamos el archivo y lo visualisamos
        //    if(ofImagen.ShowDialog() == DialogResult.OK) 
        //    {
        //        pbImagen.Image = Image.FromFile(ofImagen.FileName);
        //    }
        //}

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
