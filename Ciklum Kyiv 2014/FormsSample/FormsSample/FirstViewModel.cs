using System.ComponentModel;
using Xamarin.Forms;

namespace FormsSample
{
    public class FirstViewModel
        : INotifyPropertyChanged
    {
        string _input = "Xamarin.Forms";

        public string Input {
            get { return _input; }
            set {
                _input = value;
                OnPropertyChanged ("Input");
            }
        }

        string _output;

        public string Output {
            get { return _output; }
            set {
                _output = value;
                OnPropertyChanged ("Output");
            }
        }

        Command _magic;

        public Command Magic {
            get { return _magic ?? (_magic = new Command (DoMagic)); }
        }

        void DoMagic ()
        {
            var logic = new ComplexLogic ();
            Output = logic.Reverse (Input);
        }


        #region INotifyPropertyChanged implementation

        public event PropertyChangedEventHandler PropertyChanged;

        #endregion

        protected void OnPropertyChanged (string propertyName)
        {
            if (PropertyChanged != null) {
                PropertyChanged (this, new PropertyChangedEventArgs (propertyName));
            }
        }
    }
}

