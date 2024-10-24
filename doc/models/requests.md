
# Requests

## Structure

`Requests`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Total` | `int` | Required | - |
| `Responses` | `Dictionary<string, int>` | Optional | - |
| `Errors` | `Dictionary<string, int>` | Optional | - |

## Example (as JSON)

```json
{
  "total": 168,
  "responses": {
    "key0": 93,
    "key1": 94,
    "key2": 95
  },
  "errors": {
    "key0": 119,
    "key1": 120
  }
}
```

