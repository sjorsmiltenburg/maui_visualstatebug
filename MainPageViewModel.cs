using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace zz_maui_windows_visualstategroupbug
{
    public class MainPageViewModel : INotifyPropertyChanged
    {
        public List<MyItemViewModel> MyItems { get; set; } = new List<MyItemViewModel>();

        public MainPageViewModel()
        {
            MyItems.Add(new MyItemViewModel());
            MyItems.Add(new MyItemViewModel());
            MyItems.Add(new MyItemViewModel());
            MyItems.Add(new MyItemViewModel());
            MyItems.Add(new MyItemViewModel());
            MyItems.Add(new MyItemViewModel());
            MyItems.Add(new MyItemViewModel());
            MyItems.Add(new MyItemViewModel());
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
