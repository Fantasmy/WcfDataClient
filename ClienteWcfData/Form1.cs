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
            FrmAdd.addedStudent += new EventHandler(this.btnTcp_Click); //btnTcp = refreshTCP
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            //frmAddAlumno frmAdd = new frmAddAlumno();
            FrmAdd.ShowDialog();
        }

        private void btnHttp_Click(object sender, EventArgs e)
        {
            ReferenceWeb.Service1Client svc = new ReferenceWeb.Service1Client("Http");

            List<ReferenceWeb.Students> listaAlumnos = svc.GetAll();
            dgvAlumno.DataSource = listaAlumnos;
            //MessageBox.Show(listaAlumnos.Count.ToString());
        }

        private void btnTcp_Click(object sender, EventArgs e)
        {
            //ReferenceWeb.Service1Client svc = new ReferenceWeb.Service1Client("Tcp");
            ReferenceWeb.Service1Client svc = new ReferenceWeb.Service1Client("Tcp");
            List<ReferenceWeb.Students> listaAlumnos = svc.GetAll();
            dgvAlumno.DataSource = listaAlumnos;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            //frmUpdateAlumno frmUpdate = new frmUpdateAlumno();
            //frmUpdate.Show();

            dgvAlumno.DataSource = null;
            dgvAlumno.Rows.Clear();
            dgvAlumno.Columns.Clear();
            dgvAlumno.Refresh();

            ReferenceWeb.Service1Client svc = new ReferenceWeb.Service1Client("Http");

            Students foundStudent = svc.GetById(Guid.Parse(txtBoxId.Text));

            string[] row = new string[] {
                foundStudent.id.ToString(),
                foundStudent.name,
                foundStudent.surname,
                foundStudent.email
                };


            dgvAlumno.DataSource = row;
            AddButtons(dgvAlumno);
        }

        private void AddButtons(DataGridView grid)
        {
            // Create Edit column
            DataGridViewButtonColumn buttonEdit = new DataGridViewButtonColumn();
            buttonEdit.Name = "Edit";
            buttonEdit.HeaderText = "Edit";
            buttonEdit.Text = "Edit";
            buttonEdit.UseColumnTextForButtonValue = true;

            // Create Delete Column
            DataGridViewButtonColumn buttonRemove = new DataGridViewButtonColumn();
            buttonRemove.Name = "Delete";
            buttonRemove.HeaderText = "Delete";
            buttonRemove.Text = "Delete";
            buttonRemove.UseColumnTextForButtonValue = true;

            // Add buttons column
            grid.Columns.Add(buttonEdit);
            grid.Columns.Add(buttonRemove);
        }
    }
}
