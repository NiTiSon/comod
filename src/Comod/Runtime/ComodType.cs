namespace Comod;

public abstract class ComodType
{
	public readonly ComodTypeKind TypeKind;

	protected ComodType(ComodTypeKind typeKind)
	{
		Guard.EnsureEnumValid(typeKind);

		TypeKind = typeKind;
	}
}
