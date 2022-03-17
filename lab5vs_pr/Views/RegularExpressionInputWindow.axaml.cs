using Avalonia.Controls;
using Avalonia.Markup.Xaml;
using lab5vs_pr.ViewModels;

namespace lab5vs_pr.Views
{
    public partial class RegularExpressionInputWindow : Window
    {
        public RegularExpressionInputWindow()
        {

            InitializeComponent();


            this.FindControl<Button>("OkButton").Click += delegate
            {
                (this.DataContext as MainWindowViewModel).RegexString =
                (this.DataContext as MainWindowViewModel).RegexStringNew;
                Close();
            };

            this.FindControl<Button>("CancelButton").Click += delegate
            {
                (this.DataContext as MainWindowViewModel).RegexStringNew =
                (this.DataContext as MainWindowViewModel).RegexString;
                Close();
            };
        }

        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }
    }
}