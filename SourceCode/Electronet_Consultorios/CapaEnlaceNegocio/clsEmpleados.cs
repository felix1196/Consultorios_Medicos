using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using CapaEnlaceDatos;

namespace CapaEnlaceNegocio
{
    public class clsEmpleados
    {
        private clsManejador M = new clsManejador();
        public String? m_IdEmpleado { get; set; }
        public String? m_Nombre { get; set; }
        public String? m_Telefono { get; set; }
        public String? m_Correo { get; set; }
        public DateTime m_FechaNacimiento { get; set; } 
        public String? m_Usuario { get; set; }
        public String? m_Contraseña { get; set; }
        public String? m_TipoUsuario { get; set; }

        public DataTable MostrarEmpleados()
        {
            return M.Listado("CM_MostrarEmpleado", null);
        }

        public DataTable MostrarTipoEmpleados()
        {
            return M.Listado("CM_MostrarEmpleadosTipo", null);
        }

        public String RegistrarEmpleado()
        {
            List<clsParametro> lst = new List<clsParametro>();
            String? Mensaje = null;
            try
            {
                lst.Add(new clsParametro("@nombre", m_Nombre));
                lst.Add(new clsParametro("@telefono", m_Telefono));
                lst.Add(new clsParametro("@correo", m_Correo));
                lst.Add(new clsParametro("@fechaNacimiento", m_FechaNacimiento));                
                lst.Add(new clsParametro("@usuario", m_Usuario));
                lst.Add(new clsParametro("@contraseña", m_Contraseña));
                lst.Add(new clsParametro("@idTipoUsuario", m_TipoUsuario));

                lst.Add(new clsParametro("@Mensaje", SqlDbType.VarChar, 100));
                M.EjecutarSP("CM_RegistrarEmpleado", ref lst);
                Mensaje = lst[7].m_Valor.ToString();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return Mensaje;
        }

        public String ActualizarEmpleado()
        {
            List<clsParametro> lst = new List<clsParametro>();
            String Mensaje = "";

            try
            {
                lst.Add(new clsParametro("@idEmpleado", m_IdEmpleado));
                lst.Add(new clsParametro("@nombre", m_Nombre));
                lst.Add(new clsParametro("@telefono", m_Telefono));
                lst.Add(new clsParametro("@correo", m_Correo));
                lst.Add(new clsParametro("@fechaNacimiento", m_FechaNacimiento));
                lst.Add(new clsParametro("@usuario", m_Usuario));
                lst.Add(new clsParametro("@contraseña", m_Contraseña));
                lst.Add(new clsParametro("@idTipoUsuario", m_TipoUsuario));

                lst.Add(new clsParametro("@Mensaje", SqlDbType.VarChar, 100));
                M.EjecutarSP("CM_ActualizarEmpleado", ref lst);
                Mensaje = lst[8].m_Valor.ToString();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return Mensaje;
        }

        public String EliminarUsuario()
        {
            List<clsParametro> lst = new List<clsParametro>();
            String Mensaje = "";

            try
            {
                lst.Add(new clsParametro("@idEmpleado", m_IdEmpleado));

                lst.Add(new clsParametro("@Mensaje", SqlDbType.VarChar, 100));
                M.EjecutarSP("CM_EliminarEmpleado", ref lst);
                Mensaje = lst[1].m_Valor.ToString();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return Mensaje;
        }

    }
}