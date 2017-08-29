using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BLL
{
    class Pedido
    {

        private string numero_pedido;

        public string Numero_pedido
        {
            get { return numero_pedido; }
            set { numero_pedido = value; }
        }


        private string mesa_pedido;

        public string Mesa_pedido
        {
            get { return mesa_pedido; }
            set { mesa_pedido = value; }
        }
        private DateTime hora_data_pedido;

        public DateTime Hora_Data_pedido
        {
            get { return hora_data_pedido; }
            set { hora_data_pedido = value; }
        }

        private string status_pedido;

        public string Status_pedido
        {
            get { return status_pedido; }
            set { status_pedido = value; }
        }


    }


}
