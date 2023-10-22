using classesPOO;




class Programam
{
    static void Main()
    {
        
        Carro carro1 = new Carro();
        carro1.Marca = "Ford";
        carro1.Modelo = "Fiesta";

        Carro carro2 = new Carro("Chevrolet", "Cruze");

        Console.WriteLine(carro1.ToString());
        Console.WriteLine(carro2.ToString());

        Animal animal1 = new Animal();
        animal1.Especie = "Cachorro";
        animal1.Raca = "Labrador";

        Animal animal2 = new Animal("Gato", "Siamês");

        Console.WriteLine(animal1.ToString());
        Console.WriteLine(animal2.ToString());

        Caminhao caminhao1 = new Caminhao();
        caminhao1.Marca = "Volvo";
        caminhao1.Motor = "Diesel";

        Caminhao caminhao2 = new Caminhao("Scania", "Turbo Diesel");

        Console.WriteLine(caminhao1.ToString());
        Console.WriteLine(caminhao2.ToString());
    }
}

