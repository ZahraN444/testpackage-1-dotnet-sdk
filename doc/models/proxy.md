
# Proxy

## Structure

`Proxy`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Domain` | `string` | Optional | The proxy domain for this router. |
| `ContentMod` | [`ContentMod`](../../doc/models/content-mod.md) | Optional | Allows the load balancer to modify content before it reaches the user. |

## Example (as JSON)

```json
{
  "domain": "domain6",
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

