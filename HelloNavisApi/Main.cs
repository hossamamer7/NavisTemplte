using Autodesk.Navisworks.Api.Plugins;
using System.Windows;

namespace HelloNavisApi
{
  [Plugin("Hello Navis", "Diroots", DisplayName = "Hello Navis")]
  [RibbonLayout("HelloNavis.xaml")]
  [RibbonTab("ID_HelloNavis_1")]
  [Command("ID_Button_1",Icon = "icon16.png",LargeIcon = "icon32.png", ToolTip = "Show a message", DisplayName ="Say Hello")]
  public class Main : CommandHandlerPlugin
  {
    public override int ExecuteCommand(string name, params string[] parameters)
    {
      switch (name)
      {
        case "ID_Button_1":
          MessageBox.Show("Hello Navis!");
          break;
      }
      return 0;
    }
  }
}
