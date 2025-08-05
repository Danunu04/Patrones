using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using BE;
using DAL;
using System.Threading.Tasks;
using System.Collections;

namespace MPP
{
    public class MPPCarpeta
    {
        DALCarpeta DALC = new DALCarpeta();
        public List<Carpeta> TraerCarpetasConSCYArchivos()
        {
            int cont = 0;
            List<Carpeta>carpet = new List<Carpeta>();
            string CarpetaPadre;
            string CarpetaHijo;
            Carpeta CH = null;
            Carpeta CP=null;
            string consulta = "Select * from [dbo].[Carpeta-Carpeta]";
            DataTable dt = DALC.Buscar(consulta, null);
            foreach (DataRow item in dt.Rows)
            {
                
                CarpetaPadre = TraerNombre(Convert.ToInt32(item[0]));
                CarpetaHijo = TraerNombre(Convert.ToInt32(item[1]));
                if(cont==0)
                {
                    CP = new Carpeta(CarpetaPadre);
                    carpet.Add(CP);
                    
                }
                else if(CarpetaPadre!=CP.Name)
                {
                    CP = new Carpeta(CarpetaPadre);
                    carpet.Add(CP);
                }
                if (cont==1)
                {
                    if (CarpetaPadre != CH.Name)
                    {
                        CH = new Carpeta(CarpetaHijo);
                        CP.Agregar(CH);
                        CP.carpeta.Add(CH);
                    }
                }else
                {
                    CH = new Carpeta(CarpetaHijo);
                    CP.Agregar(CH);
                    CP.carpeta.Add(CH);
                }
               

                TraerArchivos(CP, Convert.ToInt32(item[0]));
                TraerArchivos(CH, Convert.ToInt32(item[1]));
                cont = 1;
            }
            return carpet;
        }

        private string TraerNombre(int ID)
        {
            string Nombre = "";
            string consulta = "select [Nombre] from [dbo].[Carpetas] where CarpetaID =@CarpetaID";
            ArrayList Parametros = new ArrayList();
            Parametros.Add(new SqlParameter("@CarpetaID", ID));
            DataTable dt = DALC.Buscar(consulta, Parametros);
            foreach (DataRow item in dt.Rows)
            {
                Nombre = item[0].ToString();
            }
            return Nombre;
        }

        private void TraerArchivos(Carpeta carpeta, int ID)
        {
            string Archivo;
            string consulta = "Select [ArchivoID] from [dbo].[Carpeta-Archivo] where [CarpetaID]=@Carpeta";
            ArrayList Parametros =  new ArrayList();
            Parametros.Add(new SqlParameter("@Carpeta", ID));
            DataTable dt = DALC.Buscar(consulta, Parametros);
            foreach (DataRow item in dt.Rows)
            {
                Archivo = TraerNombreArchivo(Convert.ToInt32(item[0]));
                Archivo arch = new Archivo(Archivo);
                carpeta.Agregar(arch);
                carpeta.archivo.Add(arch);
            }
        }


        private string TraerNombreArchivo(int ID)
        {
            string Nombre="";
            string consulta = "select [Nombre] from [dbo].[Archivos] where ArchivoID =@ArchivoID";
            ArrayList Parametros = new ArrayList();
            Parametros.Add(new SqlParameter("@ArchivoID", ID));
            DataTable dt = DALC.Buscar(consulta, Parametros);
            foreach (DataRow item in dt.Rows)
            {
                Nombre= item[0].ToString();
            }
            return Nombre;
        }
    }
}
