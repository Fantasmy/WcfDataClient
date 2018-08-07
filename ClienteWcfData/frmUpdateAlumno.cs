using ClienteWcfData.ReferenceWeb;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClienteWcfData
{
    public partial class frmUpdateAlumno : Form
    {
        public event EventHandler OnEdit;
        public frmUpdateAlumno( string nombre, string apellidos)
        {
            InitializeComponent();

            txtBoxNameUpdate.Text = nombre;
            txtBoxNameUpdate.Text = apellidos;

        }

        private void btnSaveUpdate_Click(object sender, EventArgs e)
        {
            ReferenceWeb.Service1Client svc = new ReferenceWeb.Service1Client("Tcp");

            Alumno alumnoNew = new Alumno { Nombre = txtBoxNameUpdate.Text, Apellidos = txtBoxSurnameUpdate.Text };

            Alumno alumnoUpdate = svc.Put(alumnoNew);

            if (alumnoUpdate != null && OnEdit != null)
            {
                OnEdit(this, e);
            }

            Close();
        }
    }
}
