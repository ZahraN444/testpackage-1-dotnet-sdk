
# Forward

## Structure

`Forward`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Scheme` | `string` | Optional | - |
| `ContentMod` | [`ContentMod`](../../doc/models/content-mod.md) | Optional | Allows the load balancer to modify content before it reaches the user. |

## Example (as JSON)

```json
{
  "scheme": "scheme6",
  "content_mod": {
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
}
```

