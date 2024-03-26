using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace curso
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Informe o valor da anuidade:");
            double anuidade = double.Parse(Console.ReadLine());

            Console.WriteLine("Qual o valor da matricula:");
            double valor = double.Parse(Console.ReadLine());

            Console.WriteLine("Valor do material:");
            double material = double.Parse(Console.ReadLine());

            Console.Write("Digite o número de parcelas: ");
            int parcelas = int.Parse(Console.ReadLine());


            double valorTotal = anuidade + valor + material;

            double parcelaUnica = valor + material;

            double parcelaMensal = (valorTotal - parcelaUnica) / parcelas;

            Console.WriteLine("Valor total do curso: R$ " + valorTotal);
            Console.WriteLine("Valor da parcela única: R$" + parcelaUnica);
            Console.WriteLine("Número de parcelas restantes:" + parcelas);
            Console.WriteLine("Valor das demais parcelas: R$" + parcelaMensal);

            Console.ReadKey();

        }
    }
}