using System;

public class SixthTesteDeMesaFutureValue
{
    public double PresentValue { get; private set; }
    public double InterestRate { get; private set; }
    public DateTime StartDate { get; private set; }
    public DateTime EndDate { get; private set; }
    public DateTime WithdrawalDate { get; private set; }
    public double WithdrawalAmount { get; private set; }

    public SixthTesteDeMesaFutureValue()
    {
        Console.Write("Informe o Valor Presente: ");
        PresentValue = Convert.ToDouble(Console.ReadLine());
        Console.Write("Informe a Taxa de Juros: ");
        InterestRate = Convert.ToDouble(Console.ReadLine()) / 100; // Convertendo porcentagem para decimal
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

        Console.WriteLine("Data\t\t\tValor Presente\tTaxa de Juros\tRendimento\tRend. Líquida\tRenda Acumulada\tResgate");

        while (currentDate <= EndDate)
        {
            double withdrawalAmountClone = 0;

            // Calcular o número de dias e converter para a fração de um mês
            TimeSpan timeSpan = currentDate - StartDate;
            double monthsElapsed = timeSpan.TotalDays / 30.0;
            double income = accumulatedIncome * Math.Pow(1 + InterestRate, monthsElapsed);
            double netIncome = income - accumulatedIncome;

            if (currentDate.Date == WithdrawalDate.Date && !wasWithdrawn)
            {
                withdrawalAmountClone = WithdrawalAmount;
                accumulatedIncome += netIncome - withdrawalAmountClone;
                wasWithdrawn = true;
            }
            else
            {
                accumulatedIncome += netIncome;
            }

            Console.WriteLine($"{currentDate:dd/MM/yyyy}\tR$ {PresentValue:F2}\t\t{InterestRate * 100:F2}%\t\tR$ {income:F2}\t" +
                              $"R$ {netIncome:F2}\tR$ {accumulatedIncome:F2}\tR$ {withdrawalAmountClone:F2}");

            // Avançar um dia
            currentDate = currentDate.AddMonths(1);

            // Atualizar o valor presente para o próximo cálculo
            PresentValue = accumulatedIncome;
        }
    }
}

