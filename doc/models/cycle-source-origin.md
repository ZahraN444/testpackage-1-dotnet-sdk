
# Cycle Source Origin

An image origin that references an image source on Cycle.

This origin will never be embedded in an image source. It is for use in stacks, describing an image which is already a part of an image source on Cycle.

## Structure

`CycleSourceOrigin`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Type` | `string` | Required, Constant | **Default**: `"cycle-source"` |
| `Details` | [`Details12`](../../doc/models/details-12.md) | Required | - |

## Example (as JSON)

```json
{
  "type": "cycle-source",
  "details": {
    "source_id": "651586fca6078e98982dbd90"
  }
}
```

