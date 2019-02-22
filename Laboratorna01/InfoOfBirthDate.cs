using Laboratorna1;
using System;
using System.Windows;

namespace Laboratorna01
{

    internal class InfoOfBirthDate : View
    {

        private string _ageT;
        private AstrologicalSign _astrologicalSign;
        private ZodiacSign _zodiacSign;
        private Visibility _visibility;
        public Visibility Visibility
        {
            get => _visibility;
            private set
            {
                if (_visibility != value)
                {
                    _visibility = value;
                    NotifyPropertyChanged();
                }
            }

        }

        public string AgeT
        {
            get => _ageT;
            private set
            {
                if (_ageT != value)
                {
                    _ageT = value;
                    NotifyPropertyChanged();
                }
            }
        }

        public AstrologicalSign AstrologicalSign
        {
            get => _astrologicalSign;
            private set
            {
                if (_astrologicalSign != value)
                {
                    _astrologicalSign = value;
                    NotifyPropertyChanged();
                }

            }
        }

        public ZodiacSign ZodiacSign
        {
            get => _zodiacSign;
            private set
            {
                if (_zodiacSign != value)
                {
                    _zodiacSign = value;
                    NotifyPropertyChanged();
                }
            }
        }

        internal InfoOfBirthDate()
        {
            Visibility = Visibility.Collapsed;
        }

        internal void BirthDateInf(DateTime birthDate)
        {
            if (DateOfBirth.DateOfBirthIsTrue(birthDate) == false)
            {
                throw new ArgumentException("Not valid birthDate");
            }
            Visibility = Visibility.Visible;
            AgeT = DateOfBirth.CalcAge(birthDate).ToString();
            AstrologicalSign = GetAstrSignOfBirthday(birthDate);
            ZodiacSign = GetZodSignOfBirthday(birthDate);
        }
        private static ZodiacSign GetZodSignOfBirthday(DateTime birthDate)
        {
            const int firstSignOfZodiac = 4;
            int ChinaCycleYear = (birthDate.Year - firstSignOfZodiac) % 12;
            return (ZodiacSign)ChinaCycleYear;
        }
        private static AstrologicalSign GetAstrSignOfBirthday(DateTime birthDate)
        {
            int AstrologicalSignOfBirthday = 0;
            int monthOfBirthday = birthDate.Month;

            switch (monthOfBirthday)
            {
                case 04:
                    {
                        if (birthDate.Day < 21)
                            AstrologicalSignOfBirthday = 0;
                        else AstrologicalSignOfBirthday = 1;
                        break;
                    }
                case 05:
                    {
                        if (birthDate.Day < 21)
                            AstrologicalSignOfBirthday = 1;
                        else AstrologicalSignOfBirthday = 2;
                        break;
                    }
                case 06:
                    {
                        if (birthDate.Day < 22)
                            AstrologicalSignOfBirthday = 2;
                        else AstrologicalSignOfBirthday = 3;
                        break;
                    }
                case 07:
                    {
                        if (birthDate.Day < 23)
                            AstrologicalSignOfBirthday = 3;
                        else AstrologicalSignOfBirthday = 4;
                        break;
                    }
                case 08:
                    {
                        if (birthDate.Day < 24)
                            AstrologicalSignOfBirthday = 4;
                        else AstrologicalSignOfBirthday = 5;
                        break;
                    }
                case 09:
                    {
                        if (birthDate.Day < 24)
                            AstrologicalSignOfBirthday = 5;
                        else AstrologicalSignOfBirthday = 6;
                        break;
                    }
                case 10:
                    {
                        if (birthDate.Day < 24)
                            AstrologicalSignOfBirthday = 6;
                        else AstrologicalSignOfBirthday = 7;
                        break;
                    }
                case 11:
                    {
                        if (birthDate.Day < 23)
                            AstrologicalSignOfBirthday = 7;
                        else AstrologicalSignOfBirthday = 8;
                        break;
                    }
                case 12:
                    {
                        if (birthDate.Day < 23)
                            AstrologicalSignOfBirthday = 8;
                        else AstrologicalSignOfBirthday = 9;
                        break;
                    }
                case 01:
                    {
                        if (birthDate.Day < 20)
                            AstrologicalSignOfBirthday = 9;
                        else AstrologicalSignOfBirthday = 10;
                        break;
                    }
                case 02:
                    {
                        if (birthDate.Day < 20)
                            AstrologicalSignOfBirthday = 10;
                        else AstrologicalSignOfBirthday = 11;
                        break;
                    }
                case 03:
                    {
                        if (birthDate.Day < 21)
                            AstrologicalSignOfBirthday = 11;
                        else AstrologicalSignOfBirthday = 0;
                        break;
                    }


            }

            return (AstrologicalSign)AstrologicalSignOfBirthday;
        }


    }
}