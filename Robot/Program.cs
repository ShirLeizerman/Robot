using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Robot
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, IRobot> robotLookup = new Dictionary<string, IRobot>();

            //Dictionary<string, Delegate> commandLookup = new Dictionary<string, Delegate>();
            Dictionary<string, MethodInfo> commandLookup = new Dictionary<string, MethodInfo>();
            Utilities.DicFromClass(commandLookup, typeof(IRobot));

            while (true)
            {
                try
                {
                    string userCommand = Console.ReadLine();
                    string[] commandSplited = userCommand.Split(null);

                    if (commandSplited.Length < 2)
                    {
                        //command not legal
                        continue;
                    }

                    string
                        robotName = commandSplited[0],
                        actionName = commandSplited[1];

                    if (actionName == "start")
                    {
                        IRobot newRobot = new Robot(robotName);
                        robotLookup.Add(robotName, newRobot);
                    }
                    else if (commandLookup.ContainsKey(actionName))
                    {
                        object[] actionParameters = (object[])commandSplited.Skip(2).Take(commandSplited.Length).ToArray();

                        commandLookup[actionName].Invoke(robotLookup[robotName], actionParameters);
                    }
                }
                catch(Exception e) {
                    Console.WriteLine("{0} Exception caught.", e);
                }
            }
        }
    }
}
