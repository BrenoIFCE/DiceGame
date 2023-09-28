using System;
internal class Program
{
    private static void Main(string[] args)
    {
        Random dice = new Random();
        int giro1 = dice.Next(1,7);
        int giro2 = dice.Next(1,7);
        int giro3 = dice.Next(1,7);

        int total = giro1 + giro2 + giro3;

        Console.WriteLine($"Giro dos dados: {giro1} + {giro2} + {giro3} = {total}");

        if (giro1 == giro2 && giro2 == giro3)
        {
            Console.WriteLine("Você girou 3 dados iguais, bônus de 6 pontos!");
            total += 6;
            Console.WriteLine($"Sua pontuação atual: {total} pontos.");
        }
        else if (giro1 == giro2 || giro2 == giro3 || giro3 == giro1)
        {
            Console.WriteLine("Você girou 2 dados iguais, bônus de 2 pontos!");
            total += 2;
            Console.WriteLine($"Sua pontuação atual: {total} pontos.");
        }

        if (total >= 16) Console.Write("Parabéns, você ganhou um carro!");
        else if(total >= 10) Console.Write("Parabéns, você ganhou um laptop!");
        else if(total == 7) Console.Write("Parabéns, você ganhou uma viagem para 2 pessoas!");
        else Console.Write("Parabéns, você ganhou um gatinho!");
    }
}
