using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DALCarpeta
    { 
        public DataTable Buscar(string consulta,ArrayList Parametros)
        {

            DataTable Dt = new DataTable();
            using (SqlConnection conn = new SqlConnection("Data Source=TECBI004\\DBPERSONAL;Initial Catalog=Gerente-Empleado;Integrated Security=True"))
            {
                using (SqlCommand cmd = new SqlCommand(consulta, conn))
                {
                    SqlDataAdapter Da;
                    cmd.CommandType = CommandType.Text;
                    try
                    {
                        // Verificar si los parámetros no son nulos antes de agregar
                        if (Parametros != null)
                        {
                            foreach (SqlParameter parametro in Parametros)
                            {
                                cmd.Parameters.AddWithValue(parametro.ParameterName, parametro.Value);
                            }
                        }

                        conn.Open();
                        Da = new SqlDataAdapter(cmd);
                        Da.Fill(Dt);
                    }
                    catch (SqlException ex)
                    {
                        throw new Exception(ex.Message);
                    }
                    catch (Exception ex)
                    {
                        throw new Exception(ex.Message);
                    }
                    finally
                    {
                        conn.Close();
                    }
                }
            }
            return Dt;
        }
    }
}
