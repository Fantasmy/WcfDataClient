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
        public frmUpdateAlumno( string nombre, string apellidos, string email)
        {
            InitializeComponent();

            txtBoxNameUpdate.Text = nombre;
            txtBoxNameUpdate.Text = apellidos;
            txtBoxEmailUpdate.Text = email;

        }

        private void btnSaveUpdate_Click(object sender, EventArgs e)
        {
            ReferenceWeb.Service1Client svc = new ReferenceWeb.Service1Client("Tcp");

            Students newStudent = new Students { name = txtBoxNameUpdate.Text, surname = txtBoxSurnameUpdate.Text, email = txtBoxEmailUpdate.Text };

            Students updatedStudent = svc.Put(Guid.Parse(txtBoxId.Text), newStudent);

            if (updatedStudent != null && OnEdit != null)
            {
                OnEdit(this, e);
            }

            Close();
        }
    }
}
