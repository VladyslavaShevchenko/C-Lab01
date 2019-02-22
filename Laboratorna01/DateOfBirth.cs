using System;

namespace Laboratorna01
{
    internal static class DateOfBirth
    {
        internal static int CalcAge(DateTime birthDate)
        {
            if (DateTime.Now.Month < birthDate.Month || (DateTime.Now.Month > birthDate.Month && DateTime.Now.Day < birthDate.Day))
            return DateTime.Now.Year - birthDate.Year - 1;
            else
                return DateTime.Now.Year - birthDate.Year;

        }
        internal static int CalcMonth(DateTime birthDate)
        {
            return DateTime.Now.Month - birthDate.Month;
        }
        internal static int CalcDay(DateTime birthDate)
        {
            return DateTime.Now.Day - birthDate.Day;
        }
        private static bool AgeIsTrue(int age, int month, int day)
        {
            return (age > 0 && age <= 135 || (age == 0 && month > 0 || month == 0 && day > 0) || (age == 0 && month > 0 && day < 0));

        }
        internal static bool DateOfBirthIsTrue(DateTime birthDate)
        {
            return AgeIsTrue(CalcAge(birthDate), CalcMonth(birthDate), CalcDay(birthDate));
        }
        internal static bool BirthdayIsTrue(DateTime birthDate)
        {
            if (DateOfBirthIsTrue(birthDate) == false)
            {
                throw new ArgumentException("Not right birthDate");
            }
            return DateTime.Now.DayOfYear == birthDate.DayOfYear;
        }
    }
}



