namespace Androsova;

public partial class About : ContentPage
{
	public About()
	{
		InitializeComponent();
	}
    private async void OnCounterClicked(object sender, EventArgs e)
    {
        // Адрес сайта
        string siteAddress = "https://www.timacad.ru/";

        // Открываем сайт в системном браузере
        await Launcher.Default.OpenAsync(siteAddress);
    }
}