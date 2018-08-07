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
        public event EventHandler AlumnoAdded; //delegate. El evento es de frmAddAlumno

        public frmAddAlumno()
        {
            InitializeComponent();
        }

        private void btnSaveAdd_Click(object sender, EventArgs e)
        {
            Alumno alumno = new Alumno();
            alumno.Nombre = txtBoxNameAdd.Text;
            alumno.Apellidos = txtBoxSurnameAdd.Text;
            ReferenceWeb.Service1Client svc = 
                new ReferenceWeb.Service1Client("Tcp");
            svc.Add(alumno);
            if (AlumnoAdded != null) // mirar que no es null, para ver que el evento apunta a algo, sino no se ejecuta
            {
                AlumnoAdded(this, e); // cual es el objeto que lanza el evento. se podria pasar un e.AlumnoAdded, así no tendriamos que vovler a ir al servicio para agregar los datos (tendrias que agregar un alumno en el grid)
            }
        }
    }
}
