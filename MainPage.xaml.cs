namespace zz_maui_windows_visualstategroupbug;

public partial class MainPage : ContentPage
{


    public MainPage()
    {
        InitializeComponent();
        this.BindingContext = new MainPageViewModel();
    }


}

