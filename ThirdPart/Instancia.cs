namespace ExerciseNine
{
    public class Instancia
    {
        public double PresentValue { get; set; }
        public double InterestRate { get; set; }
        public double PeriodOfMonths { get; set; }

        public double WithdrawalMonth { get; set; }
        public double WithdrawalAmount { get; set; }
        public double AcummulatedIncome;
        public int Month;
        public double Income;
        public double NetIncome;
        public double WithdrawalAmountClone;

        public Instancia(double presentValue, double interestRate, int periodOfMonths,
            int withdrawalMonth, double withdrawalAmount)
        {
            PresentValue = presentValue;
            InterestRate = interestRate;
            PeriodOfMonths = periodOfMonths;
            WithdrawalAmount = withdrawalAmount;
            WithdrawalMonth = withdrawalMonth;
            Month = 1;
            Income = PresentValue * Math.Pow(1 + InterestRate, Month);
            NetIncome = Income - PresentValue;
        }

    }
}