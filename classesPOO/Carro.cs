using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classesPOO
{
    class Carro
    {
      
        private static int proximoId = 1;

        
        public int Id { get; private set; }
        public string Marca { get; set; }
        public string Modelo { get; set; }

        
        public Carro()
        {
            Id = GeraId();
        }

        public Carro(string marca, string modelo)
        {
            Id = GeraId();
            Marca = marca;
            Modelo = modelo;
        }

       
        private int GeraId()
        {
            return proximoId++;
        }

        
        public override string ToString()
        {
            return $"ID: {Id}, Marca: {Marca}, Modelo: {Modelo}";
        }
    }
}
