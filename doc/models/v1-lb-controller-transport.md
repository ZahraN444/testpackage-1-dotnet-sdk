
# V1 Lb Controller Transport

Defines how traffic comes in to the load balancer, and how the load balancer handles it.

## Structure

`V1LbControllerTransport`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Disable` | `bool` | Required | When true, this controller is disabled and will not be used. |
| `Mode` | [`Mode2Enum`](../../doc/models/mode-2-enum.md) | Required | The kind of traffic (http/tcp) that will be sent to the load balancer. |
| `Config` | [`Config1`](../../doc/models/config-1.md) | Required | Defines how the transport for this controller operates. |
| `Routers` | [`List<V1LbRouterConfig>`](../../doc/models/v1-lb-router-config.md) | Required | Defines where traffic is sent. Many can be defined per controller. |

## Example (as JSON)

```json
{
  "disable": false,
  "mode": "tcp",
  "config": {
    "performance": false,
    "ingress": {
      "port": 242,
      "tls": {
        "enable": false
      }
    },
    "timeouts": {
      "idle": "72h45m2s"
    },
    "verbosity": "low",
    "extension": {
      "type": "type2",
      "details": {
        "connections": {
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
  },
  "routers": [
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
  ]
}
```

