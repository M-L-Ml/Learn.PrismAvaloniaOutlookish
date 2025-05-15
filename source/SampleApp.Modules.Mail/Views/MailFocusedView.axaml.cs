using Avalonia.Controls;
using Avalonia.Markup.Xaml;
using Avalonia.Data; // Add this for Binding

namespace SampleApp.Modules.Mail.Views;

public partial class MailFocusedView : UserControl
{
  public MailFocusedView()
  {
    InitializeComponent();

    // Programmatically bind the 'Items' property of the 'dd' ListBox to 'MailMessages'
   
    //  dd.Bind(ItemsControl.ItemsSourceProperty, new Binding("MailMessages"));
    
  }

  private void InitializeComponent()
  {
    AvaloniaXamlLoader.Load(this);
  }
}
