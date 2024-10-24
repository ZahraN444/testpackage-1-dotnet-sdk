
# V1 Lb Router Config

A specific router configuration that describes how traffic matching the rule is handled.

## Structure

`V1LbRouterConfig`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Match` | [`Match`](../../doc/models/match.md) | Required | The ruleset for this router to be selected. If both `domains` and``internal_port` are null, then this match acts as a wildcard and will match all. |
| `Mode` | [`Mode1Enum`](../../doc/models/mode-1-enum.md) | Required | How to route the traffic to the destination.<br>`random`: Pick a valid destination at random.<br>`round-robin`: Send each request to the 'next' destination on the list, restarting from the beginning when the last destination is used. |
| `Config` | [`Config`](../../doc/models/config.md) | Required | - |

## Example (as JSON)

```json
{
  "match": {
    "domains": [
      "domains0",
      "domains1",
      "domains2"
    ],
    "internal_port": [
      223,
      224,
      225
    ],
    "path": "path4"
  },
  "mode": "random",
  "config": {
    "sticky_sessions": false,
    "destination_retries": 166,
    "timeouts": {
      "destination_connection": "72h45m2s"
    },
    "tls": {
      "server_name": "server_name2",
      "allow_insecure": false,
      "client_cert_auth": "client_cert_auth6",
      "client_auth": "require"
    },
    "extension": {
      "type": "type6",
      "details": {
        "key0": {
          "key1": "val1",
          "key2": "val2"
        },
        "key1": {
          "key1": "val1",
          "key2": "val2"
        },
        "key2": {
          "key1": "val1",
          "key2": "val2"
        }
      }
    }
  }
}
```

