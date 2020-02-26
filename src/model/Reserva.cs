using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrbaHotel
{
    class Reserva
    {
        int codReserva;
        private DateTime fechaDesde;
        private DateTime fechaHasta;
        private int codigohotel;
        private int tipoHab;
        private string tipoReg;
        private Cliente unCliente;
        private int precioPorHabitacion;

        public Reserva(DateTime fechaDesde, DateTime fechaHasta, int nroHotel, Cliente unCliente, string tipoReg, int precioPorHabitacion, int tipoHab)
        {
            this.fechaDesde = fechaDesde;
            this.fechaHasta = fechaHasta;
            this.codigohotel = nroHotel;
            this.unCliente = unCliente;
            this.tipoReg = tipoReg;
            this.precioPorHabitacion = precioPorHabitacion;
            this.tipoHab = tipoHab;
        }

        public void setCodigo(int codigo)
        {
            this.codReserva = codigo;
        }


        public void guardar()
        {
            string[] param = { "@rese_fecha_desde", "@rese_fecha_hasta", "@rese_hote_codigo" , "@rese_regi_codigo" , "@rese_clie_doc_tipo", "@rese_clie_doc_nro", "@rese_clie_mail" };
            object[] args = { this.fechaDesde, this.fechaHasta, this.codigohotel, this.tipoReg, this.unCliente.getTipoDoc(), this.unCliente.getNroDoc(), this.unCliente.getMail() };
            DBConnection.Instance.executeProcedure("FAAE.guardar_reserva", param, args);
        }

        public void guardarReservaPorHabitacion()
        {
            string[] param = { "@reha_rese_codigo", "@rese_hote_codigo", "@reha_precio", "@habi_tipo_codigo" };//, "@rese_regi_codigo" , "@rese_clie_doc_tipo", "@rese_clie_doc_nro", "@rese_clie_mail" };
            object[] args = { this.codReserva, this.codigohotel, this.precioPorHabitacion, this.tipoHab };//, //this.tipoReg };, this.tipoHab };, this.estado };
            DBConnection.Instance.executeProcedure("FAAE.guardar_reservaPorHabitacion", param, args);
        }
    }
}
