using System;
using System.Diagnostics;
using System.Runtime.InteropServices;

class FourthTesteDeMesaFutureValue
{
    public static void WriteTableFutureValueOfTableWithWithdrawal(double presentValue, double interestRate, int periodOfMonths,
    int withdrawalMonth, double withdrawalAmount)
    {
        interestRate = interestRate/100;
        double acummulatedIncome;
        int month = 1;

        Console.WriteLine("Valor Presente\t\tMês\tTaxa de Juros\tRendimento\tRend. Líquida\tRenda Acumulada\tResgate");

        for (int index = 1; index <= periodOfMonths; index++)
        {
            bool wasWithdrawn = false;
            double withdrawalAmountClone = 0;
            double income = presentValue * Math.Pow(1+interestRate, month);
            double netIncome = income - presentValue;
            if (month == withdrawalMonth && wasWithdrawn == false){
                withdrawalAmountClone = withdrawalAmount;
                acummulatedIncome = presentValue + netIncome - withdrawalAmountClone;   
                presentValue = acummulatedIncome;
                month = 0;
                wasWithdrawn = true;
            }
            else
            {
            acummulatedIncome = presentValue + netIncome;
            }
            Console.WriteLine($"R$ {presentValue:F2}\t\t{month}\t{interestRate * 100:F2}%\t\tR$ {income:F2}\t"+
            $"R$ {netIncome:F2}\tR$ {acummulatedIncome:F2}\tR$ {withdrawalAmountClone:F2}");
            month ++;
        }
    }
}
