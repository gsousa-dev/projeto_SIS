using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projeto_SIS
{
    class Exercicio
    {
        private int idExercicio;
        private string descricao;
        private int tipo_exercicio;

        public Exercicio (int idExercicio, string descricao, int tipo_exercicio)
        {
            this.idExercicio = idExercicio;
            this.descricao = descricao;
            this.tipo_exercicio = tipo_exercicio;
        }

        public int ID { get { return idExercicio; } }
        public string Descricao { get { return descricao; } }
        public int Tipo_exercicio { get { return tipo_exercicio; } }



        public override string ToString()
        {
            return idExercicio + " -> " + descricao;
        }
    }
}
