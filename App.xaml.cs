namespace Androsova
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            var shell = new AppShell();
            ConfigurePlatformStyles(shell);
            MainPage = shell;
        }

        private void ConfigurePlatformStyles(Shell shell)
        {
            // Настройка цвета статус-бара (только для Android и iOS)
            if (DeviceInfo.Platform == DevicePlatform.Android || DeviceInfo.Platform == DevicePlatform.WinUI)
            {
                var statusBarColor = DeviceInfo.Platform == DevicePlatform.Android ?
                    Color.FromArgb("#1976D2") : // синий для Android
                    Color.FromArgb("#F44336");  // Красный для Win

            }
        }
    }
}
