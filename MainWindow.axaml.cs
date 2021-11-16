using System;
using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;

namespace TabsInTextBox
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
#if DEBUG
            this.AttachDevTools();
#endif

            TextBox textBox = new TextBox();
            textBox.Text =
                "This is text with tabs:" + Environment.NewLine +
                "Field1\t\t\tField2\t\t\tField3" + Environment.NewLine + 
                "Value1\t\t\tValue2\t\t\tValue3" + Environment.NewLine +
                "ID					Name						Status			CreationTime";

            textBox.AcceptsReturn = true;

            this.Content = textBox;
            this.Padding = new Thickness(20);

        }

        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }
    }
}
