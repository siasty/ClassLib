using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public interface IDllFunctions
    {
        void DllMethod();
        void SetProjectReference(IProjectFunctions projectFunctions);
    }

    public class DllClass : IDllFunctions
    {
        private IProjectFunctions _projectFunctions;

        public void DllMethod()
        {
            Console.WriteLine("DLL method called");
            // Can call project functions if reference exists
            _projectFunctions?.SomeFunction();
        }

        public void SetProjectReference(IProjectFunctions projectFunctions)
        {
            _projectFunctions = projectFunctions;
        }
    }
}
