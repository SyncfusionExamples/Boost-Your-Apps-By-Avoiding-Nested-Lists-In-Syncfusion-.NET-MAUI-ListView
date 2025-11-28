namespace NestedListViewSample;
public partial class MainPage : ContentPage
{
    public MainPage()
    {
        InitializeComponent();
    }

    private void Button_Clicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new VerticalListView());
    }

    private void Button_Clicked_1(object sender, EventArgs e)
    {
        Navigation.PushAsync(new HorizontalListView());
    }

    private void Button_Clicked_2(object sender, EventArgs e)
    {
        Navigation.PushAsync(new GroupHeaders());
    }

    private void Button_Clicked_3(object sender, EventArgs e)
    {
        Navigation.PushAsync(new ExpandableView());
    }

    private void Button_Clicked_4(object sender, EventArgs e)
    {
        Navigation.PushAsync(new TemplatePage());
    }
}