# TileFlowAI Layout Rules

## Candidate Generation

- Compare `0°` and `90°` placements.
- Search offsets within a single tile pitch.
- Use coarse-to-fine search instead of brute-forcing every possible offset.

## Tile Classification

Each tile candidate should be classified as one of the following:

- `Full`: fully inside the tileable area
- `Cut`: intersects the tileable area boundary or an exclusion boundary
- `Outside`: no usable overlap

## Preferred Scoring Order

1. Fewer cut tiles
2. Fewer unusably small pieces
3. Larger minimum cut size
4. Less waste area
5. Fewer consumed source tiles

## Practical Guardrails

- Penalize slivers below the agreed minimum size.
- Door thresholds and view axes may become tie-breakers later.
- Walls already represented by the selected boundary should not be subtracted twice.
- Exclusion zones should be explicit and traceable.

## Future Extensions

- Multi-room alignment
- Pattern layouts
- Leftover reuse rules
- Agent-assisted ambiguous object classification
