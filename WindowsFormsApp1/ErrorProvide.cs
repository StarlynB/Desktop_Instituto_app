using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class ErrorProvide : TextBox
    {
        public ErrorProvide()
        {
            InitializeComponent();
        }

        public Boolean validar
        {
            get; set;
        }
        private void ErrorProvide_Load(object sender, EventArgs e)
        {

        }
    }
}
