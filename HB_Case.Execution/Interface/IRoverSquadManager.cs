
using System.Collections.Generic;

namespace HB_Case.Execution
{
    public interface IRoverSquadManager
    {
        List<Rover> Rovers { get; }

        Rover ActiveRover { get; }

        ILandingSurface LandingSurface { get; }

        void DeployRover(int x, int y, Direction direction);
    }
}