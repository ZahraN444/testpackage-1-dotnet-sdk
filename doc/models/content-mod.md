
# Content Mod

Allows the load balancer to modify content before it reaches the user.

## Structure

`ContentMod`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Replace` | [`List<Replace>`](../../doc/models/replace.md) | Optional | An array that describes a list of replacement match/value pairs. |

## Example (as JSON)

```json
{
  "replace": [
    {
      "match": "match6",
      "value": "value6"
    },
    {
      "match": "match6",
      "value": "value6"
    },
    {
      "match": "match6",
      "value": "value6"
    }
  ]
}
```

