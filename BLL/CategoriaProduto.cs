using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BLL
{
    public class CategoriaProduto
    {
        private string bebidas;

        public string Bebidas
        {
            get { return bebidas; }
            set { bebidas = value; }
        }

        private string comidas;
        public string Comidas
        {
            get { return comidas; }
            set { comidas = value; }

        }

        private string sobremesas;

        public string Sobremesas
        {
            get { return sobremesas; }
            set { sobremesas = value; }
        }
    }
}
