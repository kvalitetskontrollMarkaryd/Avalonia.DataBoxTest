using System;
using Avalonia.Controls;
using Avalonia.DataBox.ViewModel;
using Avalonia.Markup.Xaml;

namespace Avalonia.DataBox
{
    public partial class MainWindow : Window
    {
        private MainViewModel? ViewModel => DataContext as MainViewModel;
        
        public MainWindow()
        {
            DataContext = new MainViewModel();
            
            Initialized += MainWindow_Loaded;
            
            InitializeComponent();
#if DEBUG
            this.AttachDevTools();
#endif
        }

        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }
        
        private void MainWindow_Loaded(object? sender, EventArgs e)
        {
            ViewModel!.Load();
        }
    }
}