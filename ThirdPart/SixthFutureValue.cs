using System;

public class SixthTesteDeMesaFutureValue
{
    public double PresentValue { get; private set; }
    public double MonthlyInterestRate { get; private set; }
    public DateTime StartDate { get; private set; }
    public DateTime EndDate { get; private set; }
    public DateTime WithdrawalDate { get; private set; }
    public double WithdrawalAmount { get; private set; }

    public SixthTesteDeMesaFutureValue()
    {
        Console.Write("Informe o Valor Presente: ");
        PresentValue = Convert.ToDouble(Console.ReadLine());
        Console.Write("Informe a Taxa de Juros Mensal (%): ");
        MonthlyInterestRate = Convert.ToDouble(Console.ReadLine()) / 100;
        Console.Write("Informe a Data de Início (dd/MM/yyyy): ");
        StartDate = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", null);
        Console.Write("Informe a Data de Término (dd/MM/yyyy): ");
        EndDate = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", null);
        Console.Write("Informe a Data do Resgate (dd/MM/yyyy): ");
        WithdrawalDate = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", null);
        Console.Write("Informe a Quantidade do Resgate: ");
        WithdrawalAmount = Convert.ToDouble(Console.ReadLine());
    }

    public void CalculateFutureValue()
    {
        double accumulatedIncome = PresentValue;
        bool wasWithdrawn = false;

        DateTime currentDate = StartDate;

        double dailyInterestRate = Math.Pow(1 + MonthlyInterestRate, 1.0 / 30.0) - 1;

        Console.WriteLine("Data\t\tValor Presente\tRend. Diário\tRenda Acumulada\tResgate");

        while (currentDate <= EndDate)
        {
            double dailyIncome = accumulatedIncome * dailyInterestRate;
            accumulatedIncome += dailyIncome;
            double withdrawalAmountClone = 0;

            if (currentDate.Date == WithdrawalDate.Date && !wasWithdrawn)
            {
                withdrawalAmountClone = WithdrawalAmount;
                accumulatedIncome -= withdrawalAmountClone;
                wasWithdrawn = true;
            }

            Console.WriteLine($"{currentDate:dd/MM/yyyy}\tR$ {PresentValue:F2}\tR$ {dailyIncome:F2}\t\tR$ {accumulatedIncome:F2}\tR$ {withdrawalAmountClone:F2}");

            currentDate = currentDate.AddDays(1);

            PresentValue = accumulatedIncome;
        }
    }
}
