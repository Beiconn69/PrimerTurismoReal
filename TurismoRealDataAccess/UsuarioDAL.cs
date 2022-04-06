using System;
using System.Collections.Generic;
using System.Data.OracleClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TurismoRealDataAccess
{
    public class UsuarioDAL
    {
        public static bool IsConectio()
        {
            try
            {
                using (OracleConnection ora = new OracleConnection("DATA SOURCE=localhost:1521/XEPDB1 ; PASSWORD=123456; USER ID=TURISMOADMIN;"))
                {
                    ora.Open();
                    if (ora.State == System.Data.ConnectionState.Open)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
                
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
