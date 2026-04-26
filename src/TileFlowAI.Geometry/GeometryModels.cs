namespace TileFlowAI.Geometry;

public readonly record struct Point2(double X, double Y);

public sealed record BoundaryProfile(
    IReadOnlyList<Point2> OuterLoop,
    IReadOnlyList<IReadOnlyList<Point2>> Holes)
{
    public static BoundaryProfile Empty { get; } = new([], []);
}
