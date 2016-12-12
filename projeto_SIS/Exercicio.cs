using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projeto_SIS
{
    class Exercicio
    {
        private int id;
        private string descricao;

        public int ID { get { return id; } }
        public string Descricao { get { return descricao; } }


        public override string ToString()
        {
            return id.ToString() + " -> " + descricao.ToString();
        }
    }
}
