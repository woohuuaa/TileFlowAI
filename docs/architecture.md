# TileFlowAI Architecture

## Modules

### `TileFlowAI.Plugin`

- Hosts AutoCAD commands
- Requests user selection for tile areas and exclusions
- Draws preview entities and final layout entities
- Bridges AutoCAD entity data into core models

### `TileFlowAI.Core`

- Owns layout orchestration
- Generates layout candidates
- Invokes geometry services
- Scores candidates
- Produces order-estimation results

### `TileFlowAI.Geometry`

- Defines boundary and point primitives
- Handles tile footprint classification
- Computes intersection-aware area metrics
- Supports future helper methods for exclusions and room holes

### `TileFlowAI.Reporting`

- Shapes data for summaries and exports
- Produces report-friendly DTOs
- Keeps output concerns separate from calculation logic

## Data Flow

1. AutoCAD selection is translated into `BoundaryProfile` input.
2. Core generates tile-layout candidates for each orientation and offset.
3. Geometry classifies each candidate tile as full, cut, or outside.
4. Core scores every candidate and selects the best result.
5. Reporting packages the result for preview, export, and order summary.
6. Plugin draws preview or final entities back into the drawing.

## Agent Boundary

The agent should assist with ambiguity, not replace geometry truth.

- Good agent tasks:
  layer-to-object mapping, ambiguous object classification, user-facing explanation.
- Bad agent tasks:
  exact area calculation, precise intersections, final consumed tile counts.

## Initial Dependency Direction

- `Plugin -> Core`
- `Plugin -> Reporting`
- `Core -> Geometry`
- `Reporting -> Core`

`Geometry` should stay free of AutoCAD-specific references where possible.
