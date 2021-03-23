using System;

namespace Aula_de_PC1_VelocM
{
    class Program
    {
        static void Main(string[] args)
        {
            double distância,tempo,velocidade;

            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("\nJá imaginou saber a velocidade de corrida do Flash?");
            Console.WriteLine("---------------------------------------------------");
            Console.ResetColor();
            Console.WriteLine("Parece algo de outro mundo, mas é possível utilizando uma base simples de física.\n\nComece digitando uma distância percorrida em metros:");
            distância = double.Parse(Console.ReadLine());
            Console.WriteLine("\nAgora adicione o tempo de movimento em segundos:");
            tempo = double.Parse(Console.ReadLine());
            velocidade = (distância/tempo);
            Console.WriteLine("Pressione qualquer tecla para calcular a velocidade média de corrida do Flash...");
            Console.ReadKey();
            Console.Clear();

           Console.ForegroundColor = ConsoleColor.DarkRed;
           Console.WriteLine("-------------------------------------------------------------------------------------------------------------------------");
           Console.WriteLine($"A velocidade média do super-herói Flash que percorre {distância} metros em {tempo} segundos, é igual a {velocidade} m/s!\n");
           Console.ResetColor();
        }
    }
}
