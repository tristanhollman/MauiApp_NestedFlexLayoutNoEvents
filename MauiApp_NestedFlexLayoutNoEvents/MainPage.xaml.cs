namespace MauiApp_NestedFlexLayoutNoEvents;

public partial class MainPage : ContentPage
{

    public MainPage()
    {
        InitializeComponent();

        BindingContext = this;

        var actionItems = new List<string>
        {
            "My Item"
        };
        list.ItemsSource = actionItems;
        list2.ItemsSource = actionItems;
        list3.ItemsSource = actionItems;
        list4.ItemsSource = actionItems;
    }

    private async void Button_Clicked(object sender, EventArgs e)
    {
        await DisplayAlert("Button_Clicked", "Button_Clicked", "Close");
    }

    private async void list_ItemTapped(object sender, ItemTappedEventArgs e)
    {
        await DisplayAlert("list_ItemTapped", "list_ItemTapped", "Close");
    }

    private async void TapGestureRecognizer_Tapped(object sender, TappedEventArgs e)
    {
        await DisplayAlert("TapGestureRecognizer_Tapped", "TapGestureRecognizer_Tapped", "Close");
    }
}

