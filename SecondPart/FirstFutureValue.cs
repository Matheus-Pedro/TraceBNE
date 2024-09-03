using System;

class FirstTesteDeMesaFutureValue
{
    public static double CalculatePercentualRate(double rate)
    {
        double percentualRate = rate/100;
        return percentualRate;
    }
    
    public static double CalculateFutureValue(double presentValue, double rate, int periodOfMonths)
    {
        double futureValue = presentValue * Math.Pow(1+CalculatePercentualRate(rate), periodOfMonths);
        return futureValue;
    }

}