
# Filter

## Structure

`Filter`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Resolved` | [`ResolvedEnum?`](../../doc/models/resolved-enum.md) | Optional | Get only Announcements that have been resolved, or only those that have not. |
| `Range` | [`Range2Enum?`](../../doc/models/range-2-enum.md) | Optional | The start date from when to fetch the Announcements |

## Example (as JSON)

```json
{
  "resolved": "true",
  "range": "year"
}
```

