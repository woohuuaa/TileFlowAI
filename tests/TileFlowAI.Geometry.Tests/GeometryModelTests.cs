using TileFlowAI.Geometry;
using Xunit;

namespace TileFlowAI.Geometry.Tests;

public class GeometryModelTests
{
    [Fact]
    public void EmptyBoundaryStartsWithoutVertices()
    {
        Assert.Empty(BoundaryProfile.Empty.OuterLoop);
        Assert.Empty(BoundaryProfile.Empty.Holes);
    }
}
