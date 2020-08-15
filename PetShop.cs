using System;
using System.Globalization;
namespace Projetos_C_
{
    class PetShop
    {
        private double meucaninofeliz;
        private double vairex;
        private double chowchawgas;
        public void BanhoFinalSemana(int cachorroP, int cachorroG){            
            meucaninofeliz=((cachorroP*(20*1.2))+cachorroG*(40*1.2));
            vairex=((cachorroP*20)+(cachorroG*55));
            chowchawgas=((cachorroP*30)+(cachorroG*45));
            if (chowchawgas<=vairex && chowchawgas<=meucaninofeliz){
                Console.WriteLine("\nO Melhor Petshop para o dia escolhido foi Chow Chawgas: "+"R$"+chowchawgas);
                Console.ReadLine();
            } else if(vairex<chowchawgas && vairex<=meucaninofeliz){
                Console.WriteLine("\nO Melhor Petshop para o dia escolhido foi Vai Rex: "+"R$"+vairex);
                Console.ReadLine();
            } else{
                Console.WriteLine("\nO Melhor Petshop para o dia escolhido foi Meu Canino Feliz: "+"R$"+meucaninofeliz);
                Console.ReadLine();
            }            
        }
        public void BanhoSemana(int cachorroP, int cachorroG){
            meucaninofeliz=((cachorroP*20)+(cachorroG*40));
            vairex=((cachorroP*15)+(cachorroG*50));
            chowchawgas=((cachorroP*30)+(cachorroG*45));
            if (chowchawgas<=vairex && chowchawgas<=meucaninofeliz){
                Console.WriteLine("\nO Melhor Petshop para o dia escolhido foi Chow Chawgas: "+"R$"+chowchawgas);
                Console.ReadLine();
            } else if(vairex<chowchawgas && vairex<=meucaninofeliz){
                Console.WriteLine("\nO Melhor Petshop para o dia escolhido foi Vai Rex: "+"R$"+vairex);
                Console.ReadLine();
            } else{
                Console.WriteLine("\nO Melhor Petshop para o dia escolhido foi Meu Canino Feliz: "+"R$"+meucaninofeliz);
                Console.ReadLine();
            }
        }        
    }
}
