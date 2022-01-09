namespace HB_Case.Execution
{
    public interface ILandingSurface
    {
        SurfaceSize Size { get; }

        void Define(int width, int height);
    }
}