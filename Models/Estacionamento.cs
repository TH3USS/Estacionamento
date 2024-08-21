using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EstacionamentoSystem.Models
{
    public class Estacionamento
    {
        private decimal precoInicial = 0;
        private decimal precoPorHora = 0;

        private List<string> veiculos = new List<string>();

        public Estacionamento(decimal precoInicial, decimal precoPorHora){
            this.precoInicial = precoInicial;
            this.precoPorHora = precoPorHora;
        }

        public void Adicionar(){
            Console.WriteLine("Digite a placa do veículo para estacionar:");
            string novoVeiculo = Console.ReadLine();
            if(veiculos.Contains(novoVeiculo)){
                Console.WriteLine("O veiculo já foi estacionado!");
            } else {
                veiculos.Add(novoVeiculo);
            }            
        }

        public void Remover(){
            Console.WriteLine("Digite a placa do veículo para remover");
            string placa = Console.ReadLine();

                if(veiculos.Any(x => x.ToUpper() == placa.ToUpper())){

                    Console.WriteLine("Digite a quantidade de horas que o veículo permaneceu estacionado:");

                    int horas = Convert.ToInt32(Console.ReadLine());
                    decimal valorTotal = precoInicial + precoPorHora * horas;

                    veiculos.Remove(placa);

                    Console.WriteLine($"O veículo {placa} foi removido e o preço total foi de: R$ {valorTotal}");
                } else {
                     Console.WriteLine("Desculpe, esse veículo não está estacionado aqui. Confira se digitou a placa corretamente");
                }
        }

        public void MostrarLista(){
            
            if(veiculos.Any()){
                Console.WriteLine("=============================\n" + "Os veículos estacionados são:" + "=============================");
                foreach(string v in veiculos){
                    Console.WriteLine(v);
                }
            } else {
                 Console.WriteLine("Não há veículos estacionados.");
            }
        }
    }
}