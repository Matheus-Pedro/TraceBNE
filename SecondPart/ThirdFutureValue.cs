using System;

public class ThirdTesteDeMesaFutureValue
{
    public double presentValue;
    public double interestRate;
    public double periodOfYears;

    public ThirdTesteDeMesaFutureValue()
    {
        Console.WriteLine("Digite o valor presente:");
        presentValue = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Digite a taxa de juros (em %):");
        interestRate = Convert.ToDouble(Console.ReadLine()) / 100;

        Console.WriteLine("Digite o período de tempo em anos:");
        periodOfYears = Convert.ToDouble(Console.ReadLine());
    }

    public double CalculateFutureValue()
    {
        double pow = Math.Pow(1 + interestRate, periodOfYears);
        double calculateFutureValue = presentValue * pow;
        return calculateFutureValue;
    }
}
