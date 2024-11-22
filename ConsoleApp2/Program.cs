// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

namespace ConsoleApp2
{
    class ConsoleApp2
    {
        static void Main(string [] args)
        {

            Console.WriteLine("Seja bem-vindo ao sistema de gestão de estacionamento");
            Console.WriteLine("============================");
            Console.Write("Digite o preço inicial: ");
            decimal Inicial = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("============================");
            Console.Write("Digite o preço por hora: ");
            decimal Hora = Convert.ToDecimal(Console.ReadLine());


            Estancionamento Station = new Estancionamento(Inicial, Hora);

           // string Opcoes = string.Empty;
            bool ExiberMenu = true;

            while (ExiberMenu)
            {
                Console.Clear();

                Console.WriteLine("============================");
                Console.WriteLine("Digite a sua opção");
                Console.WriteLine("============================");
                Console.WriteLine("1 --> Cadastrar veículo");
                Console.WriteLine("2 --> Remover veículo");
                Console.WriteLine("3 --> Consultar veículo");
                Console.WriteLine("4 --> Encerrar");
                Console.WriteLine("============================");

                switch (Console.ReadLine())
                {
                    case "1":
                        Station.AdicionarVeiculo();
                        break;

                    case "2":
                        Station.RemoverVeiculo();
                        break;

                    case "3":
                        Station.ListarVeiculos();
                        break;

                    case "4":
                        ExiberMenu = false;
                        break;

                    default:
                        Console.WriteLine("Opção invalida!");
                        break;
                }

                Console.WriteLine("Precione qualquer tecla para continuar");

               
            }

        }
    }
}
