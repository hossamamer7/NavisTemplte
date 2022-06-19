using Autodesk.Navisworks.Api.Plugins;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloNavisApi
{
  public class Main : CommandHandlerPlugin
  {
    [Plugin("Hello Navis", "Diroots", DisplayName = "Hello Navis")]
    public override int ExecuteCommand(string name, params string[] parameters)
    {
      return 0;
    }
  }
}
