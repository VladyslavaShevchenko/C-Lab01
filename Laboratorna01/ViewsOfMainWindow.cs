using System;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;


namespace Laboratorna01
{
    internal class ViewsOfMainWindow : View
    {
        #region Binding Properties
        public DateTime BirthDate
        {
            get => _birthDate;
            set
            {
                if (_birthDate != value)
                {
                    _birthDate = value;
                    NotifyPropertyChanged();
                }
            }
        }

        public ICommand DateSubmitCommand { get; }
        #endregion

        private DateTime _birthDate = DateTime.Now;
        private readonly InfoOfBirthDate _birthDateInfo;

        internal ViewsOfMainWindow()
        {
            DateSubmitCommand = new Async(DateExecuteAsync);

        }
        internal ViewsOfMainWindow(InfoOfBirthDate birthDateInfo) : this()
        {
            _birthDateInfo = birthDateInfo ?? throw new ArgumentNullException(nameof(birthDateInfo));
        }

        private async Task DateExecuteAsync(object o)
        {
            if (DateOfBirth.DateOfBirthIsTrue(BirthDate) == false)
            {
                MessageBox.Show("Not a right date!", "Try again", MessageBoxButton.OKCancel, MessageBoxImage.Error);
                return;
            }
            if (DateOfBirth.BirthdayIsTrue(BirthDate))
            {
                MessageBox.Show("Congratulations", "You have a birthday!",
                    MessageBoxButton.OK, MessageBoxImage.Asterisk);
            }

            await Task.Factory.StartNew(() => {
                _birthDateInfo.BirthDateInf(BirthDate);
            });

        }
    }
}