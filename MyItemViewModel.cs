using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Input;

namespace zz_maui_windows_visualstategroupbug
{
    public class MyItemViewModel : INotifyPropertyChanged
    {
        public MyItemViewModel()
        {
            Text = Guid.NewGuid().ToString();
        }

        public string Text { get; set; }

        private bool _active;
        public bool Active
        {
            get => _active; set
            {
                _active = value;
                if (_active)
                {
                    State = new VisualState() { Name = "Active" };
                }
                else
                {
                    State = new VisualState() { Name = "Normal" };
                }
            }
        }

        private VisualState _state = new VisualState() { Name = "Normal" };
        public VisualState State
        {
            get => _state; set
            {
                _state = value;
                OnPropertyChanged();
            }
        }

        public ICommand ToggleActiveCommand
        {
            get
            {
                return new Command(() =>
                {
                    Active = !Active;
                });
            }
        }


        #region INotifyPropertyChanged
        public event PropertyChangedEventHandler PropertyChanged;

        void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        #endregion

    }
}
