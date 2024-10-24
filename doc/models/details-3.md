
# Details 3

## Structure

`Details3`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Redirect` | [`Redirect`](../../doc/models/redirect.md) | Optional | Defines a built-in redirect for HTTP mode routers |
| `Forward` | [`Forward`](../../doc/models/forward.md) | Optional | - |
| `Proxy` | [`Proxy`](../../doc/models/proxy.md) | Optional | - |
| `Caching` | [`Caching`](../../doc/models/caching.md) | Optional | - |

## Example (as JSON)

```json
{
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
```

