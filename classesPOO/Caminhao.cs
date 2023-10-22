using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classesPOO
{
    class Caminhao
    {
        private static int proximoId = 1;

        public int Id { get; private set; }
        public string Marca { get; set; }
        public string Motor { get; set; }

        public Caminhao()
        {
            Id = GeraId();
        }

        public Caminhao(string marca, string motor)
        {
            Id = GeraId();
            Marca = marca;
            Motor = motor;
        }

        private int GeraId()
        {
            return proximoId++;
        }

        public override string ToString()
        {
            return $"ID: {Id}, Marca: {Marca}, Motor: {Motor}";
        }
    }
}
