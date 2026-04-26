using TileFlowAI.Core;
using TileFlowAI.Geometry;
using Xunit;

namespace TileFlowAI.Core.Tests;

public class LayoutModelTests
{
    [Fact]
    public void CanCreateLayoutInput()
    {
        var tile = new TileSpec(600, 1200, 3);
        var input = new LayoutInput(BoundaryProfile.Empty, tile, WasteRate: 0.08, CompareRotations: true, TilesPerBox: 2);

        Assert.Equal(600, input.Tile.Width);
        Assert.Equal(1200, input.Tile.Height);
        Assert.Equal(2, input.TilesPerBox);
    }
}
