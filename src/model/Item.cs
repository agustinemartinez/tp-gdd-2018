using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrbaHotel {
    public class Item {

        string codigo;
        string descripcion;
        int cantidad;
        decimal precioUnitario;

        public Item(string codigo, string descripcion, int cantidad, decimal precioUnitario) {
            this.codigo = codigo;
            this.descripcion = descripcion;
            this.cantidad = cantidad;
            this.precioUnitario = precioUnitario;
        }

        public string getCodigo() { return this.codigo; }
        public string getDescripcion() { return this.descripcion; }
        public int getCantidad() { return this.cantidad; }
        public decimal getPrecioUnitario() { return this.precioUnitario; }

        public void setPrecioUnitario(decimal precioUnitario) { this.precioUnitario = precioUnitario; }

        public decimal total() {
            return cantidad * precioUnitario;
        }
    }
}
