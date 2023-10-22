using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classesPOO
{
    class Animal
    {
        private static int proximoId = 1;

        public int Id { get; private set; }
        public string Especie { get; set; }
        public string Raca { get; set; }

        public Animal()
        {
            Id = GeraId();
        }

        public Animal(string especie, string raca)
        {
            Id = GeraId();
            Especie = especie;
            Raca = raca;
        }

        private int GeraId()
        {
            return proximoId++;
        }

        public override string ToString()
        {
            return $"ID: {Id}, Especie: {Especie}, Raca: {Raca}";
        }
    }
}
