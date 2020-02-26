using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;


namespace FrbaHotel
{
    class Habitacion
    {
        private int numero;
        private int codHotel;
        private int piso;
        private char ubicacion;
        private int tipo;
        private string descripcion;
        private bool estaHabilitada;

        public Habitacion(int numero, int codHotel, int piso, char ubicacion, int tipo, string descripcion, bool estaHabilitada)
        {
            this.numero = numero;
            this.codHotel = codHotel;
            this.piso = piso;
            this.ubicacion = ubicacion;
            this.tipo = tipo;
            this.descripcion = descripcion;
            this.estaHabilitada = estaHabilitada;
        }

        public void guardar()
        {
            string[] param = { "@habi_nro", "@habi_hote_codigo", "@habi_piso", "@habi_vista_exterior", "@habi_tipo_codigo", "@habi_habilitada", "@habi_descripcion"};
            object[] args = { this.numero, this.codHotel, this.piso, this.ubicacion, this.tipo, this.estaHabilitada, this.descripcion};
            DBConnection.Instance.executeProcedure("FAAE.guardar_habitacion", param, args);
        }

        public void modificar()
        {

        }

        public void inhabilitar()
        {
            string[] param = { "@habi_nro"};
            object[] args = { this.numero };
            DBConnection.Instance.executeProcedure("FAAE.inhabilitar_habitacion", param, args);
           // this.estaHabilitada = false;
        }


    }
}
