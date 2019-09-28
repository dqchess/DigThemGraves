using System.Collections.Generic;

namespace DigThemGraves
{
    public delegate void GraveyardCallback(IGrave grave);
	public interface IGraveyard
	{
        event GraveyardCallback OnGraveBuilt;
		List<IBuildSlot> BuildSlots { get; }
        IGrave LastBuildGrave { get; }
	}
}
