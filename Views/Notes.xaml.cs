namespace Androsova.Views;

public partial class Notes : ContentPage
{
    int count = 0;

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
        var noteModel = (Models.Note)BindingContext;
        try
        {
            await File.WriteAllTextAsync(noteModel.FilePath, InputEntry.Text);
            LableText.Text = $"Заметка сохранена в: {noteModel.FilePath}";

        }
        catch (Exception ex)
        {
            LableText.Text = $"Ошибка сохранения: {ex.Message}";

        }
    }

    private void OnCounterClicked4(object sender, EventArgs e)
    {
        var noteModel = (Models.Note)BindingContext;
        if (File.Exists(noteModel.FilePath))
        {
            File.Delete(noteModel.FilePath);
            LableText.Text = "Заметка удалена";
        }
        else
        {
            LableText.Text = "Заметка не найдена";
        }
    }

    private async void LoadSavedText()
    {
        var noteModel = (Models.Note)BindingContext;
        if (File.Exists(noteModel.FilePath))
        {
            InputEntry.Text = await File.ReadAllTextAsync(noteModel.FilePath);
        }

    }
}