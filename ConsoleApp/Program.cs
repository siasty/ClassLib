using ClassInterfaces;
using ConsoleApp;
using DLLProject;

internal class Program
{
    private static void Main(string[] args)
    {
        IDllFunctions dll = new dllClass();
        var project = new projectClass(dll);
        project.InitializeDll();

        Console.WriteLine("Starting test:");
        project.SomeFunction();
        dll.DllMethod();
        Console.WriteLine($"DLL getting project data: {((dllClass)dll).GetProjectData(42)}");
        project.CallDllSeparately();
    }
}