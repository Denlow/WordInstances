using Nancy;
using System.Collections.Generic;
using Anagram.Objects;

namespace Instances
{
  public class HomeModule : NancyModule
  {
    public HomeModule()
    {
      Get{"/"} = _ => {
        return View["index.cshtml"];
      };
      Post["/form"] = _ => {
        InstanceGenerator newInstanceGenerator = new InstanceGenerator(Request.Form["inputWords"]);
        return View ["result.cshtml", newInstanceGenerator];
      };
    }
  }
}
