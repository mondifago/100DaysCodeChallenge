namespace _100DaysCodeChallenge.Day_2
{
    public class LoanEligibilityChecker
    {
        public bool IsEligibleForLoan(Applicant applicant)
        {
            return applicant.Age >= 21 && applicant.MonthlyIncome >= 2000 && applicant.YearsEmployed >= 2;
        }
    }
}
