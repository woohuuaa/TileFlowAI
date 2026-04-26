# TileFlowAI Order Calculation

## Initial Conservative Model

The first implementation should prioritize under-order prevention.

```text
theoretical minimum tiles = ceil(tileable net area / tile area)
consumed tiles = full tiles + cut source tiles
suggested order tiles = ceil(consumed tiles * (1 + waste rate))
suggested box count = ceil(suggested order tiles / tiles per box)
```

## Definitions

- `theoretical minimum tiles`
  Pure area-based estimate. Useful as a reference, but usually too optimistic.
- `consumed tiles`
  Estimate based on layout behavior. A cut tile counts as consuming a source tile in the first version.
- `suggested order tiles`
  Consumption adjusted with waste allowance.

## Open Business Rules

- Can cut leftovers be reused within the same room?
- Can leftovers be reused across rooms?
- Should box count always round up even when waste is already included?

## Reporting Recommendation

Expose both of these values in the UI and reports:

- theoretical minimum tiles
- suggested order tiles

This helps users understand the difference between area-only and layout-aware estimates.
