using System;
using System.Globalization;
using System.Threading;
namespace Projetos_C_
{
    class Program
    {
        static void Main(string[] args)
        {
            int cachorroP,cachorroG,numerodia;
            PetShop pet = new PetShop();
                        
            Console.Write("Digite a quantidade de Cachorros PEQUENOS para o Banho: ");
            cachorroP=Convert.ToInt32(Console.ReadLine());
            Console.Write("Digite a quantidade de Cachorros GRANDES para o Banho: ");
            cachorroG=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digite a Data para o Banho ");
            Console.WriteLine("Exemplo: 03/08/2018\n");
            DateTime diasemana = DateTime.Parse(Console.ReadLine());
            numerodia=((int) diasemana.DayOfWeek);
            if(numerodia==6 || numerodia==0){
                pet.BanhoFinalSemana(cachorroP,cachorroG);
            }else
                pet.BanhoSemana(cachorroP,cachorroG);

        }
    }
}
