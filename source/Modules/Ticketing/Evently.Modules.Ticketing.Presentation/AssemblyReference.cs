using System.Reflection;

namespace Evently.Modules.Ticketing.Presentation;

public static class AssemblyReference
{
    public static Assembly Assembly => typeof(AssemblyReference).Assembly;
}
