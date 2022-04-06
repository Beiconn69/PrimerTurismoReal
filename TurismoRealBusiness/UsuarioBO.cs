using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TurismoRealDataAccess;
using TurismoRealEntities;

namespace TurismoRealBusiness
{
    public class UsuarioBO
    {
        public static bool IsConction()
        {
            try
            {
                bool respuesta = UsuarioDAL.IsConectio();
                return respuesta;


            }
            catch (Exception)
            {

                throw;
            }
        }

        public bool ValidarDatos(EmpleadoEntity empleado)
        {
            bool resultado = true;

            if (empleado.em_rut == string.Empty)
            {
                MessageBox.Show("Inserte un RUT válido");
                return false;
            }
            if (string.IsNullOrEmpty(empleado.em_contrasena))
            {
                MessageBox.Show("Inserte contraseña");
                return false;
            }

            return resultado;
        }
        
    }
}
