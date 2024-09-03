using System;

class FifthTesteDeMesaFutureValue
{
    public static double CalculatePercentualRate(double rate)
    {
        double percentualRate = rate/100;
        return percentualRate;
    }

    public static double CalculatePeriodOfMonths(double periodOfYears)
    {
        double periodOfMonths = periodOfYears * 12;
        return periodOfMonths;
    }
    
    public static double CalculatePresentValue(double futureValue, double rate, int periodOfYears)
    {
        double presentValue = futureValue / Math.Pow(1+CalculatePercentualRate(rate), CalculatePeriodOfMonths(periodOfYears));
        return presentValue;
    }
}
