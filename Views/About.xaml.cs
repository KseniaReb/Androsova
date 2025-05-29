namespace Androsova.Views;

public partial class About : ContentPage
{
	public About()
	{
		InitializeComponent();
	}
    private async void OnCounterClicked(object sender, EventArgs e)
    {

        // Открываем сайт в системном браузере
        var aboutModel = (Models.About)BindingContext;
        await Launcher.Default.OpenAsync(aboutModel.siteAddress);
    }
}