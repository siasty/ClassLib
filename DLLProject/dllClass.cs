using ClassInterfaces;

namespace DLLProject
{
    public class dllClass : IDllFunctions
    {
        private IProjectFunctions _projectFunctions;

        public void DllMethod()
        {
            Console.WriteLine("DLL method called");
        }

        public void SetProjectReference(IProjectFunctions projectFunctions)
        {
            _projectFunctions = projectFunctions;
        }
        public string GetProjectData(int id)
        {
            return _projectFunctions?.GetData(id) ?? "No project reference";
        }
    }

}
