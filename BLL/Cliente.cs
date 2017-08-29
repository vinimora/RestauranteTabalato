using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class cliente
    {
        private string cliente_cpf;

        public string Cliente_cpf
        {
            get { return cliente_cpf; }
            set { cliente_cpf = value; }
        }

        private string nome_Cliente;
        public string Nome_Cliente
        {
            get { return nome_Cliente; }
            set { nome_Cliente = value; }
        }
        private string cliente_telefone;


        public string Cliente_telefone
        {
            get { return cliente_telefone; }
            set { cliente_telefone = value; }

        }
    }
}
