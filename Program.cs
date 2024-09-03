using System;

class Program
{
    static void Main()
    {
        Title.WriteTitle();
        while (true)
        {
            Console.WriteLine("·············································································");
            Console.WriteLine("Escolha qual o número do programa no qual você deseja executar:" + 
            "\n- 1) Primeiro Teste de Mesa (Parte 1)"+
            "\n- 2) Segundo Teste de Mesa (Parte 1)"+
            "\n- 3) Terceiro Teste de Mesa (Parte 1)"+
            "\n- 4) Primeiro Teste de Mesa (Parte 2)"+
            "\n- 5) Segundo Teste de Mesa (Parte 2)"+
            "\n- 6) Terceiro Teste de Mesa (Parte 2)"+
            "\n- 7) Quarto Teste de Mesa (Parte 2)"+
            "\n- 8) Quinto Teste de Mesa (Parte 2)");
            Console.Write(":");
            int numberIndex = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("·············································································");
            switch (numberIndex)
            {
                case 1:
                    TesteDeMesa.FirstTrace();
                    break;
                case 2:
                    TesteDeMesa.SecondTrace();
                    break;
                case 3:
                    TesteDeMesa.ThirdTrace();
                    break;
                case 4:
                    double firstFutureValue = FirstTesteDeMesaFutureValue.CalculateFutureValue(1000.00,  5.30, 10);
                    Console.WriteLine($"\nO valor futuro calculado é: {firstFutureValue:F2}");
                    break;
                case 5:
                    SecondTesteDeMesaFutureValue.WriteTableFutureValue(3800.00, 1.25, 6);
                    break;
                case 6:
                    ThirdTesteDeMesaFutureValue trace = new();
                    double futureValue = trace.CalculateFutureValue();
                    Console.WriteLine($"\nO valor futuro calculado é: {futureValue:F2}");
                    break;
                case 7:
                    FourthTesteDeMesaFutureValue.WriteTableFutureValueOfTableWithWithdrawal(2000.00, 2.00, 8, 5, 1000.00);
                    break;
                case 8:
                    double presentValue = FifthTesteDeMesaFutureValue.CalculatePresentValue(7390.61, 1.25, 2);
                    Console.WriteLine($"\nO valor presente calculado é: {presentValue:F2}");
                    break;
                default:
                    Console.WriteLine("ERRO: O programa escolhido não foi encontrado, tente outro index.");
                    break;
            }
        }
    }
}
