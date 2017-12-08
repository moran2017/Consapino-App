using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


namespace Consapino.App.BE
{
    public class UsuarioBE
    {

        public String Codigo { get; set; }
        public String Password { get; set; }
        public ErrorBE objError { get; set; }

        public UsuarioBE(String codigo, String password)
        {
            this.Codigo = codigo;
            this.Password = password;

            this.objError = new ErrorBE(1, "Operecion incorrecta");

        }

        public UsuarioBE(int codError, String strError)
        {
            this.objError = new ErrorBE(codError, strError);
        }
    }
}