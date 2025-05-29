namespace Androsova;

public partial class Notes : ContentPage
{
    int count = 0;
    private readonly string _filename = Path.Combine(FileSystem.AppDataDirectory, "notes.txt");


    public Notes()
    {
        InitializeComponent();
        LoadSavedText();
    }
    private void OnCounterClicked1(object sender, EventArgs e)
    {
        count++;

        if (count == 1)
            CounterBtn.Text = $"Clicked {count} time";
        else
            CounterBtn.Text = $"Clicked {count} times";

        SemanticScreenReader.Announce(CounterBtn.Text);
    }
    private void OnCounterClicked2(object sender, EventArgs e)
    {
        string inputText = InputEntry.Text;
        LableText.Text = inputText; ;
    }
    private async void OnCounterClicked3(object sender, EventArgs e)
    {
        try
        {
            await File.WriteAllTextAsync(_filename, InputEntry.Text);
            LableText.Text = $"Заметка сохранена в: {_filename}";

        }
        catch (Exception ex)
        {
            LableText.Text = $"Ошибка сохранения: {ex.Message}";

        }
    }

    private void OnCounterClicked4(object sender, EventArgs e)
    {
        if (File.Exists(_filename))
        {
            File.Delete(_filename);
            LableText.Text = "Заметка удалена";
        }
        else
        {
            LableText.Text = "Заметка не найдена";
        }
    }

    private async void LoadSavedText()
    {
        if (File.Exists(_filename))
        {
            InputEntry.Text = await File.ReadAllTextAsync(_filename);
        }
        
    }
}