using System;
using ExerciseNine;

public class SixthTesteDeMesaFutureValue
{
    private readonly Instancia Instancia;

    public SixthTesteDeMesaFutureValue(Instancia instancia)
    {
        Instancia = instancia;
    }

    public bool getArgs(double presentValue, double interestRate, int periodOfMonths,
            int withdrawalMonth, double withdrawalAmount)
    {
        Instancia.PresentValue = presentValue;
        Instancia.InterestRate = interestRate;
        Instancia.PeriodOfMonths = periodOfMonths;
        Instancia.WithdrawalAmount = withdrawalAmount;
        Instancia.WithdrawalMonth = withdrawalMonth;

        WriteTableFutureValueOfTableWithWithdrawal(Instancia);
        return true;
    }

    public void CalculateInterestRate(Instancia instancia)
    {
        Instancia.InterestRate = instancia.InterestRate / 100;
    }

    public void WriteHeaderTable()
    {
        Console.WriteLine("Valor Presente\t\tMês\tTaxa de Juros\tRendimento\tRend. Líquida\tRenda Acumulada\tResgate");
    }

    public void WriteBodyTable(Instancia instancia)
    {
        Console.WriteLine($"R$ {instancia.PresentValue:F2}\t\t{instancia.Month}\t{instancia.InterestRate * 100:F2}%\t\tR$ {instancia.Income:F2}\t" +
            $"R$ {instancia.NetIncome:F2}\tR$ {instancia.AcummulatedIncome:F2}\tR$ {instancia.WithdrawalAmountClone:F2}");
    }
    public void WriteTableFutureValueOfTableWithWithdrawal(Instancia instancia)
    {
        CalculateInterestRate(instancia);

        WriteHeaderTable();

        for (int index = 1; index <= Instancia.PeriodOfMonths; index++)
        {
            bool wasWithdrawn = false;
            if (instancia.Month == instancia.WithdrawalMonth && wasWithdrawn == false)
            {
                instancia.WithdrawalAmountClone = instancia.WithdrawalAmount;
                instancia.AcummulatedIncome = instancia.PresentValue + instancia.NetIncome - instancia.WithdrawalAmountClone;
                instancia.PresentValue = instancia.AcummulatedIncome;
                instancia.Month = 0;
                wasWithdrawn = true;
            }
            else
            {
                instancia.AcummulatedIncome = instancia.PresentValue + instancia.NetIncome;
            }
            WriteBodyTable(instancia);
            Instancia.Month++;
        }
    }
}