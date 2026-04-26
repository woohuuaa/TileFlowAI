using TileFlowAI.Geometry;

namespace TileFlowAI.Core;

public sealed record TileSpec(double Width, double Height, double JointWidth = 0);

public sealed record LayoutInput(
    BoundaryProfile Boundary,
    TileSpec Tile,
    double WasteRate = 0.08,
    bool CompareRotations = true,
    int? TilesPerBox = null);

public enum TilePlacementKind
{
    Full,
    Cut,
}

public sealed record TilePlacement(
    TilePlacementKind Kind,
    Point2 Origin,
    double Width,
    double Height);

public sealed record LayoutScore(
    int CutTileCount,
    int SmallSliverCount,
    double MinimumCutSize,
    double WasteArea,
    int ConsumedTileCount);

public sealed record LayoutResult(
    string CandidateName,
    IReadOnlyList<TilePlacement> Placements,
    LayoutScore Score);

public sealed record OrderEstimate(
    int TheoreticalMinimumTiles,
    int ConsumedTiles,
    int SuggestedTiles,
    int? SuggestedBoxes);

public interface ILayoutPlanner
{
    LayoutResult Evaluate(LayoutInput input);
}

public interface IOrderEstimator
{
    OrderEstimate Estimate(LayoutResult layout, LayoutInput input);
}
