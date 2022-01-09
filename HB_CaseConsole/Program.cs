﻿using HB_Case.Execution;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace HB_CaseConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            var serviceProvider = new ServiceCollection()
                .AddSingleton<ILandingSurface, Plataeu>()
                .AddSingleton<IRoverSquadManager, RoverSquadManager>()
                .BuildServiceProvider();

            var commandCenter = new CommandCenter(serviceProvider);
            commandCenter.SendCommand("5 5");
            commandCenter.SendCommand("1 2 N");
            commandCenter.SendCommand("LMLMLMLMM");
            commandCenter.SendCommand("3 3 E");
            commandCenter.SendCommand("MMRMMRMRRM");

            Console.ReadKey();
        }
    }
}
