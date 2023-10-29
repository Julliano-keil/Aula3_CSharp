using classesPOO;

class Programam
{
    static void Main()
    {
        Console.WriteLine(" digite 1 para cadastrar carro \n\n digite 2 para cadastrar animais \n\n digite 3 para cadastrar caminhao");
        int namber = Convert.ToInt32(Console.ReadLine());


        switch (namber)
        {
            case 1:
                car();
                break;
            case 2:
                animal();
                break;
            case 3:
                truck();
                break;
            default:
                Console.WriteLine("opçao invalida!");
                break;
        }
    }

    public static void car()
    {
        Console.WriteLine("informe uma marca");
        string information = Console.ReadLine();
        Console.WriteLine("informe uma modelo");
        string information_Two = Console.ReadLine();

        Carro carro = new Carro();

        carro.Marca = information;
        carro.Modelo = information_Two;

        Console.WriteLine($" marca cadastrada: {information}, modelo cadastrado: {information_Two}");
    }
    public static void animal()
    {
        Console.WriteLine("informe uma especie");
        string information = Console.ReadLine();
        Console.WriteLine("informe uma Raça");
        string information_Two = Console.ReadLine();

        Animal animal = new Animal();
        animal.Especie = information;
        animal.Raca = information_Two;

        Console.WriteLine($" especie cadastrada: {information}, Raça cadastrado: {information_Two}");
    }

    public static void truck()
    {
        Console.WriteLine("informe uma marca de caminhao");
        string information = Console.ReadLine();
        Console.WriteLine("informe o motor");
        string information_Two = Console.ReadLine();

        Caminhao caminhao = new Caminhao();
        caminhao.Marca = information;
        caminhao.Motor = information_Two;
        Console.WriteLine(caminhao.ToString());

        Console.WriteLine($" marca do caminhao cadastrada: {information}, motor cadastrado: {information_Two}");
    }

}

