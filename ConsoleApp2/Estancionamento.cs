using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class Estancionamento
    {
        private decimal PrecoInicial = 0;
        private decimal PrecoPorHora = 0;
        List<string> Veiculos = new List<string>();

        public Estancionamento(decimal PrecoInic, decimal PrecoPorhora)
        {
            PrecoInicial = PrecoInic;
            PrecoPorHora = PrecoPorhora;
        }

       
        public void AdicionarVeiculo()
        {
            int contador = 0;
            
            Console.Write("Digite a placa do seu veículo: ");
            string placa = Console.ReadLine();

            Veiculos.Add(placa);

            
            contador++;
        }

        public void RemoverVeiculo()
        {

            string placa = "";

            Console.Write("Digite a placa do seu veículo: ");
            placa = Console.ReadLine();

            if (Veiculos.Any(x => x.ToUpper() == placa.ToUpper()))
            {
                int hora = 0;
                Console.Write("Digite o tempo de estancionamento: ");
                hora = Convert.ToInt32(Console.ReadLine());

                decimal ValorTotal = PrecoInicial + PrecoPorHora * hora;

                Veiculos.Remove(placa);

                Console.WriteLine($"O veículo {placa} foi removido do estancionamento e o preço total foi de {ValorTotal}");

            }
            else
            {
                Console.WriteLine($"Desculpa, mas não foi encontrado o veículo {placa}, verifica se digitou corretamento a placa do seu veículo");
            }
            

            







        }

        public void ListarVeiculos()
        {
            if (Veiculos.Any())
            {
                int contador = 0;
                foreach (var item in Veiculos)
                {
                    Console.WriteLine("Os veículos estacionados são:");
                    Console.WriteLine("=================");
                    Console.WriteLine(Veiculos[contador]);

                    contador++;
                }
            }
            else
            {
                Console.WriteLine("Não há veículos estancionados");
            }
        }
    }
}
