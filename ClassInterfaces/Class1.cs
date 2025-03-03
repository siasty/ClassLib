namespace ClassInterfaces
{
    public interface IProjectFunctions
    {
        void SomeFunction();
        string GetData(int id);
    }

    public interface IDllFunctions
    {
        void DllMethod();
        void SetProjectReference(IProjectFunctions projectFunctions);
    }
}
