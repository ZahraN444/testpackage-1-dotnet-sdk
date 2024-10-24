
# V1 Lb Controller

## Structure

`V1LbController`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Default` | `bool` | Required | - |
| `Identifier` | `string` | Required | A human-readable identifier for this controller. It will default to the port, i.e. `port-443`, but can be renamed to anything, such as the service this controller represents. |
| `Transport` | [`V1LbControllerTransport`](../../doc/models/v1-lb-controller-transport.md) | Required | Defines how traffic comes in to the load balancer, and how the load balancer handles it. |

## Example (as JSON)

```json
{
  "default": false,
  "identifier": "identifier0",
  "transport": {
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
}
```

