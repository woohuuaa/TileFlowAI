using TileFlowAI.Core;

namespace TileFlowAI.Reporting;

public sealed record LayoutSummary(
    string CandidateName,
    int FullTileCount,
    int CutTileCount,
    int ConsumedTiles,
    int SuggestedTiles,
    int? SuggestedBoxes);

public interface IReportFormatter
{
    string Format(LayoutResult layout, OrderEstimate estimate);
}
