namespace HB_Case.Execution
{
    public interface IVehicle
    {
        int X { get; }

        int Y { get; }

        ILandingSurface LandingSurface { get; }

        Direction Direction { get; }

        void Move(MovementEnum movement);
    }
}