using System;

class SecondTesteDeMesaFutureValue
{
    public static void WriteTableFutureValue(double presentValue, double interestRate, int periodOfMonths)
    {
        interestRate = interestRate/100;
        double acummulatedIncome = presentValue;
        
        Console.WriteLine("Mês\tTaxa de Juros\tRendimento\tRend. Líquida\tRenda Acumulada");

        for (int month = 1; month <= periodOfMonths; month++)
        {

            double income = presentValue * Math.Pow(1+interestRate, month);
            double netIncome = income - presentValue;
            acummulatedIncome += netIncome;

            
            Console.WriteLine($"{month}\t{interestRate * 100:F2}%\t\tR$ {income:F2}\tR$ {netIncome:F2}\tR$ {acummulatedIncome:F2}");
        }
    }
}
