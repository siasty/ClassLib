using ClassInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    internal class projectClass : IProjectFunctions
    {
        private readonly IDllFunctions _dllFunctions;

        public projectClass(IDllFunctions dllFunctions)
        {
            _dllFunctions = dllFunctions;
        }

        public void SomeFunction()
        {
            Console.WriteLine("Project function called");
        }

        public string GetData(int id)
        {
            return $"Data for ID: {id}";
        }

        public void InitializeDll()
        {
            _dllFunctions.SetProjectReference(this);
        }

        public void CallDllSeparately()
        {
            _dllFunctions.DllMethod();
        }
    }
}
