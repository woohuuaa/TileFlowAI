# TileFlowAI MVP Spec

## Goal

Build a first usable AutoCAD workflow that can preview rectangular tile layouts inside a selected area, compare simple placement options, and estimate ordering quantity.

## Supported in MVP

- One selected tileable area at a time
- Closed boundary input
- Rectangular tiles only
- `0°` and `90°` layout comparison
- Joint width input
- Offset search within one tile pitch
- Full tile and cut tile classification
- Conservative order estimation
- Preview before final draw-back into CAD

## Out of Scope for MVP

- Herringbone, diagonal, and pattern layouts
- Automatic full-drawing room detection
- Cross-room leftover reuse optimization
- Multi-material layouts
- Full AI-only object recognition without user confirmation

## Inputs

- Selected tileable boundary
- Optional excluded boundaries
- Tile width
- Tile height
- Joint width
- Waste rate
- Optional tiles-per-box
- Preferred comparison mode: `0°`, `90°`, or both

## Outputs

- Candidate layout previews
- Best-layout recommendation
- Full tile count
- Cut tile count
- Consumed tile count
- Suggested order quantity
- Optional suggested box count

## Default Assumptions

- Fixed objects can be selected manually in the first iteration.
- A cut tile consumes one source tile for ordering unless a reuse rule is explicitly implemented.
- Very small slivers should be penalized during scoring.
- CAD entity recognition should start with deterministic rules before agent assistance.

## Open Decisions

- Supported AutoCAD version
- First-release plugin target framework
- Default minimum acceptable cut size
- Which objects are always exclusion zones versus layout references
