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
    public partial class frmAddAlumno : Form
    {
        public event EventHandler addedStudent; //delegate. El evento es de frmAddAlumno

        public frmAddAlumno()
        {
            InitializeComponent();
        }

        private void btnSaveAdd_Click(object sender, EventArgs e)
        {
            Students student = new Students();
            student.name = txtBoxNameAdd.Text;
            student.surname = txtBoxSurnameAdd.Text;
            student.email = txtBoxEmailAdd.Text;
            ReferenceWeb.Service1Client svc = 
                new ReferenceWeb.Service1Client("Tcp");
            svc.Post(student);
            if (addedStudent != null) // mirar que no es null, para ver que el evento apunta a algo, sino no se ejecuta
            {
                addedStudent(this, e); // cual es el objeto que lanza el evento. se podria pasar un e.AlumnoAdded, así no tendriamos que vovler a ir al servicio para agregar los datos (tendrias que agregar un alumno en el grid)
            }
        }
    }
}
