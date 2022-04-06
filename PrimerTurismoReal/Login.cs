using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OracleClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TurismoRealBusiness;
using TurismoRealEntities;


namespace PrimerTurismoReal
{
    public partial class Login : Form
    {
        
        public Login()
        {
            InitializeComponent();
        }
        UsuarioBO v_usuarioBO = new UsuarioBO();
        EmpleadoEntity v_empleadoEntity1 = new EmpleadoEntity();
        private void btnConectar_Click(object sender, EventArgs e)
        {

            //Conectar();
            

            EmpleadoEntity empleadoEntity = new EmpleadoEntity();
            empleadoEntity.em_rut = txtRut.Text;
            empleadoEntity.em_contrasena = txtContrasena.Text;

            v_usuarioBO.ValidarDatos(empleadoEntity);

        }


        public  void Conectar()
        {
            bool isconection = UsuarioBO.IsConction();
            if (isconection)
            {
                MessageBox.Show("Conectado");
            }
            else
            {
                MessageBox.Show("No está conectado a la base de datos");
            }
            
        }
    }
}
