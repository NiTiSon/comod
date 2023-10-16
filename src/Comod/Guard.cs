using System.Diagnostics;

namespace Comod;

internal static class Guard
{
	[StackTraceHidden]
	public static void EnsureEnumValid<EnumType>(EnumType value)
		where EnumType : Enum
	{
		if (!Enum.IsDefined(typeof(EnumType), value))
			throw new ArgumentException("Argument has invalid value.", nameof(value));
	}
}