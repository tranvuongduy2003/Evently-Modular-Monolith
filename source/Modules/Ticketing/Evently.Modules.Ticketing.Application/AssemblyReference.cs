using System.Reflection;

namespace Evently.Modules.Ticketing.Application;

public static class AssemblyReference
{
    public static Assembly Assembly => typeof(AssemblyReference).Assembly;
}

