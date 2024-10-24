
# Stats

## Structure

`Stats`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `State` | `Dictionary<string, int>` | Optional | A count of this resource, grouped by state. |
| `Total` | `int?` | Optional | The total number of this resource |
| `Available` | `int?` | Optional | The total number of this resource available, less any deleted ones. |

## Example (as JSON)

```json
{
  "state": {
    "key0": 40,
    "key1": 39,
    "key2": 38
  },
  "total": 128,
  "available": 174
}
```

