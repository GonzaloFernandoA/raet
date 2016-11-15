using System;
using System.Reflection;

namespace ParenthesesBalancing
{
  class Program
  {
    /// <summary>
    /// Entry point of the application.
    /// Necessary to run NUnit tests in Visual Studio 2010 Express Edition.
    /// </summary>
    [STAThread]
    static void Main(string[] args)
    {
      string[] nUnitArgs = { Assembly.GetExecutingAssembly().Location };

      int returnCode = NUnit.ConsoleRunner.Runner.Main(nUnitArgs);

      if (returnCode != 0)
      {
        Console.Beep();
      }
    }
  }
}
