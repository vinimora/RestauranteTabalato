using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BLL
{
    public class Mesas
    {
        private string numero_mesa;

        public string Numero_mesa
        {
            get { return numero_mesa; }
            set { numero_mesa = value; }
        }


        private string status_mesa;

        public string Status_mesa
        {
            get { return status_mesa; }
            set { status_mesa = value; }
        }
    }
}
