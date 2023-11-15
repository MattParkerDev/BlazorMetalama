using Metalama.Framework.Aspects;
using Metalama.Framework.Fabrics;

namespace Blazor.Metalama;

// Unusable until Metalama.Compiler properly supports Razor source generators, or using <UseRazorSourceGenerator>false</UseRazorSourceGenerator>.
public class LogAttribute : OverrideMethodAspect
{
	public override dynamic? OverrideMethod()
	{
		Console.WriteLine("AnotherAttribute");
		return meta.Proceed();
	}
}
