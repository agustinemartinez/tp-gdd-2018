using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace FrbaHotel {
    public class Usuario {

        private string docTipo;
        private long docNro;
        private string username;
        private string password;
        private string nombre;
        private string apellido;
        private string mail;
        private string telefono;
        private string direCalle;
        private long direNro;
        private DateTime fechaNacimiento;
        private int loginFallidos;
        private long hotelUltimoLogin;
        private bool habilitado;
        private List<string> roles;
        private List<Hotel> hoteles;
        private bool exists;

        public string DocTipo { get { return docTipo; } set { docTipo = value; } }
        public long DocNro { get { return docNro; } set { docNro = value; } }
        public string Username { get { return username; } set { username = value; } }
        public string Password { get { return password; } set { password = value; } }
        public string Nombre { get { return nombre; } set { nombre = value; } }
        public string Apellido { get { return apellido; } set { apellido = value; } }
        public string Mail { get { return mail; } set { mail = value; } }
        public string Telefono { get { return telefono; } set { telefono = value; } }
        public string DireCalle { get { return direCalle; } set { direCalle = value; } }
        public long DireNro { get { return direNro; } set { direNro = value; } }
        public DateTime FechaNacimiento { get { return fechaNacimiento; } set { fechaNacimiento = value; } }
        public int LoginFallidos { get { return loginFallidos; } set { loginFallidos = value; } }
        public long HotelUltimoLogin { get { return hotelUltimoLogin; } set { hotelUltimoLogin = value; } }
        public bool Habilitado { get { return habilitado; } set { habilitado = value; } }
        public List<string> Roles { get { return roles; } }
        public List<Hotel> Hoteles { get { return hoteles; } }
        public bool Exists { get { return exists; } set { exists = value; } }

        public void agregarRol(string rol) { this.roles.Add(rol); }
        public void agregarHotel(Hotel hotel) { this.hoteles.Add(hotel); }
        public void limpiarRoles() { this.roles = new List<string>(); }
        public void limpiarHoteles() { this.hoteles = new List<Hotel>(); }
        
        public Usuario(string username) {
            this.username = username;
            this.password = "";
            this.hotelUltimoLogin = 0;
            this.loginFallidos = 0;
            this.habilitado = false;
            this.roles = new List<string>();
            this.hoteles = new List<Hotel>();
            this.exists = false;
        }

        public Usuario(string username, string password) {
            this.username = username;
            this.password = password;
            this.hotelUltimoLogin = 0;
            this.habilitado = false;
            this.roles = new List<string>();
            this.hoteles = new List<Hotel>();
            this.exists = false;
        }

        private bool estaHabilitado() {
            SqlDataReader dataReader = DBConnection.Instance.executeQuery("SELECT usua_habilitado FROM FAAE.Usuario WHERE usua_username = '" + this.username + "'");
            dataReader.Read();
            this.habilitado = dataReader["usua_habilitado"].Equals(true);
            dataReader.Close();
            return this.habilitado;
        }

        public bool tieneUsernameUnico() {
            bool usernameUnico;
            SqlDataReader dataReader = DBConnection.Instance.executeQuery("SELECT COUNT(*) existencias FROM FAAE.Usuario WHERE usua_username = '" + this.username + "'");
            dataReader.Read();
            usernameUnico = (int)dataReader["existencias"] == 0;
            dataReader.Close();
            return usernameUnico;
        }

        public void ingresar() {
            if(this.usernamePasswordCorrectos()) {
                if(this.estaHabilitado())
                    this.limpiarLoginFallidos();
            }
            else
                this.registrarLoginFallido();
        }

        public bool ingresoCorrectamente() {
            return this.exists && this.estaHabilitado();
        }

        private bool usernamePasswordCorrectos() {
            SqlDataReader dataReader = DBConnection.Instance.executeQuery("SELECT 1 FROM FAAE.Usuario WHERE usua_username = '" + this.username + "' AND usua_password = HASHBYTES('SHA2_256', CONVERT(VARCHAR(255), '" + this.password + "'))");
            this.exists = dataReader.Read();
            dataReader.Close();
            return this.exists;
        }

        private void limpiarLoginFallidos() {
            string[] param = { "@username" };
            string[] args = { this.username };
            DBConnection.Instance.executeProcedure("FAAE.limpiar_login_fallidos", param, args);
        }

        private void registrarLoginFallido() {
            string[] param = { "@username" };
            string[] args = { this.username };
            DBConnection.Instance.executeProcedure("FAAE.login_fallido", param, args);
        }

        public void inhabilitar() {
            string[] param = { "@username" };
            object[] args = { this.username };
            DBConnection.Instance.executeProcedure("FAAE.inhabilitar_usuario", param, args);
            this.habilitado = false;
        }

        public void buscar() {
            string query = "SELECT usua_doc_tipo, usua_doc_nro, usua_username, usua_password, usua_nombre, usua_apellido, usua_mail, usua_telefono, usua_dire_calle, usua_dire_nro, usua_fecha_nacimiento, usua_cant_log_in_fallidos, COALESCE(usua_hote_codigo_ultimo_log_in, 0) usua_hote_codigo_ultimo_log_in, usua_habilitado";
            query += " FROM FAAE.Usuario WHERE usua_username = '" + this.username + "'";
            SqlDataReader dataReader = DBConnection.Instance.executeQuery(query);

            if (dataReader.Read()) {
                this.docTipo = dataReader["usua_doc_tipo"].ToString();
                this.docNro = Convert.ToInt64(dataReader["usua_doc_nro"].ToString());
                this.username = dataReader["usua_username"].ToString();
                //this.password = dataReader["usua_password"].ToString();
                this.nombre = dataReader["usua_nombre"].ToString();
                this.apellido = dataReader["usua_apellido"].ToString();
                this.mail = dataReader["usua_mail"].ToString();
                this.telefono = dataReader["usua_telefono"].ToString();
                this.direCalle = dataReader["usua_dire_calle"].ToString();
                this.direNro = Convert.ToInt64(dataReader["usua_dire_nro"]);
                this.fechaNacimiento = Convert.ToDateTime(dataReader["usua_fecha_nacimiento"]);
                this.loginFallidos = Convert.ToInt32(dataReader["usua_cant_log_in_fallidos"]);
                this.hotelUltimoLogin = Convert.ToInt64(dataReader["usua_hote_codigo_ultimo_log_in"]);
                this.habilitado = dataReader["usua_habilitado"].Equals(true);
                this.exists = true;
            }
            dataReader.Close();

            query = "SELECT rous_rol_nombre FROM FAAE.Rol_Usuario WHERE rous_clie_doc_tipo = '" + this.docTipo + "' AND rous_clie_doc_nro = " + this.docNro;
            dataReader = DBConnection.Instance.executeQuery(query);

            while (dataReader.Read())
                this.roles.Add(dataReader["rous_rol_nombre"].ToString());

            dataReader.Close();

            query = "SELECT hote_codigo, hote_nombre FROM FAAE.Hotel_Usuario JOIN FAAE.Hotel ON (hous_hote_codigo = hote_codigo)";
            query += " WHERE hous_usua_doc_tipo = '" + this.docTipo + "' AND hous_usua_doc_nro = " + this.docNro + " AND hous_usua_mail = '" + this.mail + "'";
            dataReader = DBConnection.Instance.executeQuery(query);

            int cod;
            string nom;
            while (dataReader.Read()) {
                cod = Convert.ToInt32(dataReader["hote_codigo"]);
                nom = dataReader["hote_nombre"].ToString();
                this.hoteles.Add(new Hotel(cod, nom));            
            }
            dataReader.Close();
        }

        public void guardar() {
            string sqlDate = this.fechaNacimiento.ToString("yyyy-MM-dd HH:mm:ss.fff");
            string[] param1 = { "@usua_doc_tipo", "@usua_doc_nro", "@usua_username", "@usua_password", "@usua_nombre", "@usua_apellido", "@usua_mail", "@usua_telefono", "@usua_dire_calle", "@usua_dire_nro", "@usua_fecha_nacimiento", "@usua_cant_log_in_fallidos", "@usua_hote_codigo_ultimo_log_in", "@usua_habilitado" };
            object[] args1 = { this.docTipo, this.docNro, this.username, this.password, this.nombre, this.apellido, this.mail, this.telefono, this.direCalle, this.direNro, sqlDate, this.loginFallidos, this.hotelUltimoLogin, this.habilitado };
            DBConnection.Instance.executeProcedure("FAAE.guardar_usuario", param1, args1);

            string[] param2 = { "@usua_username" };
            object[] args2 = { this.username };
            DBConnection.Instance.executeProcedure("FAAE.eliminar_roles_usuario", param2, args2);

            string[] param3 = { "@usua_username", "@rol_nombre" };
            this.roles.ForEach(rol => {
                object[] args3 = { this.username, rol };
                DBConnection.Instance.executeProcedure("FAAE.asignar_rol_usuario", param3, args3);
            });

            string[] param4 = { "@usua_username" };
            object[] args4 = { this.username };
            DBConnection.Instance.executeProcedure("FAAE.eliminar_hoteles_usuario", param4, args4);

            string[] param5 = { "@usua_username", "@hous_hote_codigo" };
            this.hoteles.ForEach(hotel => {
                object[] args5 = { this.username, hotel.getCodigo() };
                DBConnection.Instance.executeProcedure("FAAE.asignar_hotel_usuario", param5, args5);
            });
        }

    }
}
