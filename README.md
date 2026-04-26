# TileFlowAI

TileFlowAI is an AutoCAD plugin for tile layout planning on existing floor plans. It simulates tile placement, compares layout strategies to reduce tile cuts, and estimates the total quantity required for ordering.

TileFlowAI 是一款 AutoCAD 外掛，針對既有平面圖進行磁磚排版模擬、比較不同鋪貼方案的碎磚與耗料結果，並估算建議下單數量。

## Core Goals

- Simulate tile layouts directly on an existing floor plan
- Compare `0°` and `90°` placement with offset search
- Reduce cut tiles and avoid unusably small pieces
- Estimate consumed tiles, suggested order quantity, and optional box count
- Preview layouts before committing them to the CAD drawing

## Planned MVP

- Manual selection of a closed tileable area
- Optional manual or assisted selection of fixed objects to exclude
- Rectangular tiles only
- `0°` and `90°` layout comparison
- Joint width support
- Preview layer and final layout layer output
- Order estimation with configurable waste rate

## Architecture

- `TileFlowAI.Plugin`
  AutoCAD command entry, selection flow, preview, and final drawing output.
- `TileFlowAI.Core`
  Layout orchestration, candidate evaluation, scoring, and order estimation.
- `TileFlowAI.Geometry`
  Boundary models, intersection helpers, and tile classification utilities.
- `TileFlowAI.Reporting`
  Layout summary and export-oriented report models.

## Repository Structure

```text
TileFlowAI/
├── docs/
├── samples/
├── src/
│   ├── TileFlowAI.Plugin/
│   ├── TileFlowAI.Core/
│   ├── TileFlowAI.Geometry/
│   └── TileFlowAI.Reporting/
├── tests/
│   ├── TileFlowAI.Core.Tests/
│   └── TileFlowAI.Geometry.Tests/
├── DESIGNER_QUESTIONNAIRE.md
├── DESIGNER_QUESTIONNAIRE_LINE.md
└── TileFlowAI.sln
```

## Key Docs

- `docs/mvp-spec.md`
- `docs/architecture.md`
- `docs/layout-rules.md`
- `docs/order-calculation.md`
- `docs/roadmap.md`
- `DESIGNER_QUESTIONNAIRE.md`
- `DESIGNER_QUESTIONNAIRE_LINE.md`

## Current Status

- Repo skeleton initialized
- Product naming aligned to `TileFlowAI`
- MVP, architecture, layout, and order-estimation documents added
- Solution and project placeholders created for the first implementation pass

## Open Decisions

- Which AutoCAD version should be supported first
- Whether the first plugin target should be `net48` or a newer Windows target aligned with your AutoCAD version
- Which fixed objects should be excluded automatically versus selected manually
- Whether first-release ordering should use the conservative cut-tile consumption rule

## Next Build Steps

1. Confirm target AutoCAD version and plugin framework.
2. Implement geometry primitives and rectangular room prototype.
3. Add candidate generation and scoring for `0°` and `90°` layouts.
4. Add order-estimation logic and report output.
5. Connect the engine to AutoCAD selection and preview commands.
