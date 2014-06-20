using System.Windows.Input;
using Cirrious.MvvmCross.ViewModels;

namespace MvxSample.Core
{

    public class FirstViewModel 
        : MvxViewModel
    {
        string _input = "Xamarin and MvvmCross";

        public string Input {
            get { return _input; }
            set {
                _input = value;
                RaisePropertyChanged (() => Input);
            }
        }

        string _output;

        public string Output {
            get { return _output; }
            set {
                _output = value;
                RaisePropertyChanged (() => Output);
            }
        }

        ICommand _magic;

        public ICommand Magic {
            get {
                _magic = _magic ?? new MvxCommand (DoMagic);
                return _magic;
            }
        }

        void DoMagic ()
        {
            var logic = new ComplexLogic ();
            Output = logic.Reverse (Input);
        }
    }
    
}