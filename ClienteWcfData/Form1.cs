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
    public partial class Form1 : Form
    {
        frmAddAlumno FrmAdd;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            FrmAdd = new frmAddAlumno();
            FrmAdd.AlumnoAdded += new EventHandler(this.btnTcp_Click);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            //frmAddAlumno frmAdd = new frmAddAlumno();
            FrmAdd.Show();
        }

        private void btnHttp_Click(object sender, EventArgs e)
        {
            ReferenceWeb.Service1Client svc = new ReferenceWeb.Service1Client("Http");

            List<ReferenceWeb.Alumno> listaAlumnos = svc.GetAll();
            dgvAlumno.DataSource = listaAlumnos;
            //MessageBox.Show(listaAlumnos.Count.ToString());
        }

        private void btnTcp_Click(object sender, EventArgs e)
        {
            //ReferenceWeb.Service1Client svc = new ReferenceWeb.Service1Client("Tcp");
            ReferenceWeb.Service1Client svc = new ReferenceWeb.Service1Client("Tcp");
            List<ReferenceWeb.Alumno> listaAlumnos = svc.GetAll();
            dgvAlumno.DataSource = listaAlumnos;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            frmUpdateAlumno frmUpdate = new frmUpdateAlumno();
            frmUpdate.Show();
        }
    }
}
