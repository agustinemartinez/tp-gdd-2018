using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrbaHotel
{
    class CheckIn
    {
        private string reseCodigo;
        private string docTipo;
        private int docNro;
        private string mail;
        private string docTipoUsua;
        private int docNroUsua;
        private string mailUsua;

        public CheckIn(string reseCodigo, string docTipo, int docNro, string mail, string docTipoUsua, int docNroUsua, string mailUsua)
        {
            this.reseCodigo = reseCodigo;
            this.docTipo = docTipo;
            this.docNro = docNro;
            this.mail = mail;
            this.mail = mail;
            this.docTipoUsua = docTipoUsua;
            this.docNroUsua = docNroUsua;
            this.mailUsua = mailUsua;
        }

        public void guardar()
        {
            string[] param = { "@reseCodigo", "@docTipo", "@docNro", "@mail", "@docTipoUsua", "@docNroUsua", "@mailUsua" };
            object[] args = { this.reseCodigo, this.docTipo, this.docNro, this.mail, this.docTipoUsua, this.docNroUsua, this.mailUsua };
            DBConnection.Instance.executeProcedure("FAAE.guardar_checkIn", param, args);
        }
    }
}
