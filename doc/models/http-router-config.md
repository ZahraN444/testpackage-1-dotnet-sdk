
# Http Router Config

Additional configuration options for HTTP mode routers.

## Structure

`HttpRouterConfig`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Type` | `string` | Required, Constant | **Default**: `"http"` |
| `Details` | [`Details3`](../../doc/models/details-3.md) | Required | - |

## Example (as JSON)

```json
{
  "type": "http",
  "details": {
    "redirect": {
      "auto_https_redirect": false,
      "remove_www": false,
      "port": 2,
      "scheme": "scheme0",
      "url": "url4"
    },
    "forward": {
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
    },
    "proxy": {
      "domain": "domain8",
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
    },
    "caching": {
      "files": [
        {
          "match": "match4",
          "ttl": "ttl4"
        },
        {
          "match": "match4",
          "ttl": "ttl4"
        }
      ]
    }
  }
}
```

