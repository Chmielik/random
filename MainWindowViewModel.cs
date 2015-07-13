using GalaSoft.MvvmLight.CommandWpf;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace WpfApplication2
{
    public class MainWindowViewModel : GalaSoft.MvvmLight.ViewModelBase
    {
        private Random random;
        private int numbersTo;
        private int actualResult;


        private void DoRandCommand()
        {
            this.NextNumber();

        }

        private bool CanRand()
        {
            if (numbersTo == 0 || UsedNumbers.Count() == numbersTo)
                return false;
            else
                return true;
        }

        private bool CanUndo()
        {
            return UsedNumbers.Count() > 1;
        }

        private void DoStartRand()
        {
            IsReadonly = true;
        }

        private bool CanStartRand()
        {
            return !IsReadonly;
        }

        private void DoUndo()
        {
            UsedNumbers.RemoveAt(UsedNumbers.Count()-1);
            ActualResult = UsedNumbers.Last();
        }

        private ICommand startRandCommand;

        public ICommand StartRandCommand
        {
            get { return startRandCommand; }
        }

        private ICommand randCommand;

        public ICommand RandCommand
        {
            get { return randCommand; }
        }

        private ICommand undoCommand;

        public ICommand UndoCommand
        {
            get { return undoCommand; }
        }

        private bool isReadonly;

        public bool IsReadonly
        {
            get { return isReadonly; }
            set { 
                isReadonly = value;
                RaisePropertyChanged("IsReadonly");
            }

        }

        public MainWindowViewModel()
        {
            random = new Random();
            randCommand = new RelayCommand(DoRandCommand, CanRand);
            startRandCommand = new RelayCommand(DoStartRand, CanRand);
            undoCommand = new RelayCommand(DoUndo, CanUndo);
            this.UsedNumbers = new List<int>();
        }
        public List<int> UsedNumbers { get; set; }
        public int NumbersTo
        {
            get
            {
                return this.numbersTo;
            }
            set
            {
                this.numbersTo = value;
            }
        }

        public int ActualResult
        {
            get
            {
                return this.actualResult;
            }
            set
            {
                this.actualResult = value;
                RaisePropertyChanged("ActualResult");
            }
        }

        private void NextNumber()
        {
            int result;
            do
            {
                result = random.Next(1, NumbersTo+1);
            }
            while (UsedNumbers.Contains(result));

            this.ActualResult = result;
            this.UsedNumbers.Add(result);
        }
    }
}
