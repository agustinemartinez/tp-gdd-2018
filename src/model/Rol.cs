using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrbaHotel {
    public class Rol {

        private string nombre;
        private bool habilitado;
        private List<string> funcionalidades;

        public Rol(string nombre) {
            this.nombre = nombre;
            this.habilitado = true;
            this.funcionalidades = new List<string>();
        }

        public string getNombre() { return nombre; }
        public bool getHabilitado() { return habilitado; }
        public List<string> getFuncionalidades() { return funcionalidades; }

        public void setHabilitado(bool habilitado) { this.habilitado = habilitado; }
        public void agregarFuncionalidad(string funcionalidad) { this.funcionalidades.Add(funcionalidad); }
        public void limpiarFuncionalidades() { this.funcionalidades = new List<string>(); }

        public void inhabilitar() {
            string[] param = { "@nombre" };
            object[] args = { this.nombre };
            DBConnection.Instance.executeProcedure("FAAE.inhabilitar_rol", param, args);
            this.habilitado = false;
        }

        public void buscar() {
            string query = "SELECT func_funcion FROM FAAE.Funcionalidad WHERE func_rol_nombre = '" + this.nombre + "'";
            SqlDataReader dataReader = DBConnection.Instance.executeQuery(query);

            while (dataReader.Read())
                this.funcionalidades.Add(dataReader["func_funcion"].ToString());

            dataReader.Close();

            query = "SELECT rol_habilitado FROM FAAE.Rol WHERE rol_nombre = '" + this.nombre + "'";
            dataReader = DBConnection.Instance.executeQuery(query);

            if (dataReader.Read())
                this.habilitado = (bool)dataReader["rol_habilitado"];

            dataReader.Close();
        }

        public void guardar() {
            string[] param1 = { "@rol_nombre", "@rol_habilitado" };
            object[] args1 = { this.nombre, this.habilitado };
            DBConnection.Instance.executeProcedure("FAAE.guardar_rol", param1, args1);

            string[] param2 = { "@rol_nombre"};
            object[] args2 = { this.nombre };
            DBConnection.Instance.executeProcedure("FAAE.eliminar_funcionalidades_rol", param2, args2);
            
            string[] param3 = { "@rol_nombre", "@funcionalidad" };
            this.funcionalidades.ForEach( funcionalidad => {
                object[] args3 = { this.nombre, funcionalidad };
                DBConnection.Instance.executeProcedure("FAAE.asignar_funcionalidad_rol", param3, args3);
            });
        }

    }
}
