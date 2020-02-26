using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace FrbaHotel
{
    public class Cliente
    {
        string tipoDoc;
        int nroDoc;
        string nombre;
        string apellido;
        string mail;
        string telefono;
        string calle;
        int numero;
        string localidad;
        string pais;
        string nacionalidad;
        int habilitado;
        DateTime fechaNac;
        int piso;
        string depto;

        public Cliente() { }

        public Cliente(string tipoDoc, int nroDoc, string nombre, string apellido, string mail, string telefono, string calle, int numero,
            string localidad, string pais, string nacionalidad, int habilitado, DateTime fechaNac, int piso, string depto)
        {
            this.tipoDoc = tipoDoc;
            this.nroDoc = nroDoc;
            this.nombre = nombre;
            this.apellido = apellido;
            this.mail = mail;
            this.telefono = telefono;
            this.calle = calle;
            this.numero = numero;
            this.localidad = localidad;
            this.pais = pais;
            this.nacionalidad = nacionalidad;
            this.habilitado = habilitado;
            this.fechaNac = fechaNac;
            this.piso = piso;
            this.depto = depto;
        }

        public Cliente(string tipoDoc, int nroDoc, string mail) //para guardarlo en la reserva solo necesita estos 3 atributos
        {
            this.tipoDoc = tipoDoc;
            this.nroDoc = nroDoc;
            this.mail = mail;
        }



        public void setTipoDoc(string tipoDoc) { this.tipoDoc = tipoDoc; }
        public void setNroDoc(int nroDoc) { this.nroDoc = nroDoc; }
        public void setNombre(string nombre) { this.nombre = nombre; }
        public void setApellido(string apellido) { this.apellido = apellido; }
        public void setMail(string mail) { this.mail = mail; }
        public void setTelefono(string telefono) { this.telefono = telefono; }
        public void setCalle(string calle) { this.calle = calle; }
        public void setNumero(int numero) { this.numero = numero; }
        public void setLocalidad(string localidad) { this.localidad = localidad; }
        public void setPais(string pais) { this.pais = pais; }
        public void setNacionalidad(string nacionalidad) { this.nacionalidad = nacionalidad; }
        public void setHabilitado(int habilitado) { this.habilitado = habilitado; }
        public void setFechaNac(DateTime fechaNac) { this.fechaNac = fechaNac; }
        public void setPiso(int piso) { this.piso = piso; }
        public void setDepto(string depto) { this.depto = depto; }

        public string getTipoDoc() { return tipoDoc; }
        public int getNroDoc() { return nroDoc; }
        public string getNombre() { return nombre; }
        public string getApellido() { return apellido; }
        public string getMail() { return mail; }
        public string getTelefono() { return telefono; }
        public string getCalle() { return calle; }
        public int getNumero() { return numero; }
        public string getLocalidad() { return localidad; }
        public string getPais() { return pais; }
        public string getNacionalidad() { return nacionalidad; }
        public int getHabilitado() { return habilitado; }
        public DateTime getFechaNac() { return fechaNac; }
        public int getPiso() { return piso; }
        public string getDepto() { return depto; }

        public void registrar(AbmCliente.frmAltaCliente frmAlta)//Regitro al cliente verificando que no esta creado y que nadie use el mismo mail
        {
            if (this.mailRepetido())
            {
                MessageBox.Show("El mail ya ha sido utilizado, ingrese uno distinto.");
            }
            else
            {
                try
                {
                    SqlDataReader dataReader = DBConnection.Instance
                        .executeQuery("INSERT INTO FAAE.Cliente VALUES('" + tipoDoc + "'," + nroDoc + ",'" + nombre + "','" + apellido + "','" + mail + "','" + telefono + "','" + calle + "'," + numero + ",'" + localidad + "','" + pais + "','" + nacionalidad + "'," + habilitado + ", CONVERT(SMALLDATETIME, CONVERT(DATETIME, '" + fechaNac.ToShortDateString() + "'))" + "," + piso + ",'" + depto + "')");
                    MessageBox.Show("Cliente creado correctamente");
                    dataReader.Close();
                    frmAlta.Close();
                    AbmCliente.frmABMCliente i = new AbmCliente.frmABMCliente();
                    i.Show();
                }
                catch (Exception e)
                {
                    MessageBox.Show("Usuario ya creado."+e.ToString());
                }
            }
        }

        public void modificar(AbmCliente.frmModificarCliente frmModificar)
        {
            
                try
                {
                    string[] param = { "@tipoDoc", "@nroDoc", "@nombre", "@apellido", "@mail", "@telefono", "@calle", "@numero", "@localidad", "@pais", "@nacionalidad", "@habilitado", "@fechaNac", "@piso", "@depto" };
                    object[] args = { this.tipoDoc, this.nroDoc, this.nombre, this.apellido, this.mail, Convert.ToInt32(this.telefono),this.calle,this.numero,this.localidad,this.pais,this.nacionalidad,Convert.ToInt32(this.habilitado),this.fechaNac,Convert.ToInt32(this.piso),this.depto };
                    DBConnection.Instance.executeProcedure("FAAE.modificar_cliente", param, args);
                    MessageBox.Show("Cliente modificado correctamente");
                    frmModificar.Close();
                    AbmCliente.frmABMCliente i = new AbmCliente.frmABMCliente();
                    i.Show();
                }
                catch (Exception e)
                {
                    MessageBox.Show("Datos mal ingresados." + e.ToString());
                }
            }

        public bool mailRepetido()
        {
            SqlDataReader dataReader = DBConnection.Instance.executeQuery("SELECT COUNT(*) cant FROM FAAE.Cliente WHERE clie_mail = '" + mail + "'");
            dataReader.Read();
            bool n = Convert.ToInt32(dataReader["cant"]) != 0;
            dataReader.Close();
            return n;
        }

        public void buscar()
        {

            string query = "SELECT * FROM FAAE.Cliente WHERE clie_mail = '" + this.mail + "'";
            SqlDataReader dataReader = DBConnection.Instance.executeQuery(query);

            if (dataReader.Read())
            {
                this.tipoDoc = dataReader["clie_doc_tipo"].ToString();
                this.nroDoc = Convert.ToInt32(dataReader["clie_doc_nro"]);
                this.nombre = dataReader["clie_nombre"].ToString();
                this.apellido = dataReader["clie_apellido"].ToString();
                this.mail = dataReader["clie_mail"].ToString();
                this.telefono = dataReader["clie_telefono"].ToString();
                this.calle = dataReader["clie_dire_calle"].ToString();
                this.numero = Convert.ToInt32(dataReader["clie_dire_nro"]);
                this.localidad = dataReader["clie_dire_localidad"].ToString();
                this.pais = dataReader["clie_dire_pais"].ToString();
                this.nacionalidad = dataReader["clie_nacionalidad"].ToString();
                this.habilitado = Convert.ToInt32(dataReader["clie_habilitado"]);
                this.fechaNac = Convert.ToDateTime(dataReader["clie_fecha_nacimiento"]);
                this.piso = Convert.ToInt32(dataReader["clie_piso"]);
                this.depto = dataReader["clie_depto"].ToString();
            }

            dataReader.Close();
        }

    }
}
