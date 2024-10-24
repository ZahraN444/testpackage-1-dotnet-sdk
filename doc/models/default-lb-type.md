
# Default Lb Type

## Structure

`DefaultLbType`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Ipv4` | `bool` | Required | Allow / disallow traffic to be routed via IPv4. |
| `Ipv6` | `bool` | Required | Allow / disallow traffic to be routed via IPv6. |
| `Type` | `string` | Required, Constant | **Default**: `"default"` |
| `Details` | [`DefaultLbTypeDetails`](../../doc/models/containers/default-lb-type-details.md) | Required | This is a container for one-of cases. |

## Example (as JSON)

```json
{
  "ipv4": false,
  "ipv6": false,
  "type": "default",
  "details": {
    "controllers": [
      {
        "default": null,
        "identifier": null,
        "transport": {
          "disable": null,
          "mode": null,
          "config": {
            "performance": null,
            "ingress": null,
            "timeouts": {
              "idle": "72h45m2s"
            },
            "verbosity": null
          },
          "routers": [
            {
              "match": null,
              "mode": null,
              "config": {
                "sticky_sessions": null,
                "destination_retries": null,
                "timeouts": {
                  "destination_connection": "72h45m2s"
                }
              }
            }
          ]
        }
      }
    ],
    "default": {
      "frontend": {
        "mode": "tcp",
        "max_connections": 190,
        "timeouts": {
          "client_secs": 228,
          "client_fin_ms": 250,
          "http_keep_alive_ms": 122,
          "http_request_ms": 102
        }
      },
      "backend": {
        "balance": "roundrobin",
        "timeouts": {
          "server_secs": 200,
          "server_fin_ms": 126,
          "connect_ms": 174,
          "queue_ms": 16,
          "tunnel_secs": 16
        }
      }
    },
    "ports": {
      "key0": {
        "frontend": {
          "mode": "tcp",
          "max_connections": 190,
          "timeouts": {
            "client_secs": 228,
            "client_fin_ms": 250,
            "http_keep_alive_ms": 122,
            "http_request_ms": 102
          }
        },
        "backend": {
          "balance": "roundrobin",
          "timeouts": {
            "server_secs": 200,
            "server_fin_ms": 126,
            "connect_ms": 174,
            "queue_ms": 16,
            "tunnel_secs": 16
          }
        }
      },
      "key1": {
        "frontend": {
          "mode": "tcp",
          "max_connections": 190,
          "timeouts": {
            "client_secs": 228,
            "client_fin_ms": 250,
            "http_keep_alive_ms": 122,
            "http_request_ms": 102
          }
        },
        "backend": {
          "balance": "roundrobin",
          "timeouts": {
            "server_secs": 200,
            "server_fin_ms": 126,
            "connect_ms": 174,
            "queue_ms": 16,
            "tunnel_secs": 16
          }
        }
      },
      "key2": {
        "frontend": {
          "mode": "tcp",
          "max_connections": 190,
          "timeouts": {
            "client_secs": 228,
            "client_fin_ms": 250,
            "http_keep_alive_ms": 122,
            "http_request_ms": 102
          }
        },
        "backend": {
          "balance": "roundrobin",
          "timeouts": {
            "server_secs": 200,
            "server_fin_ms": 126,
            "connect_ms": 174,
            "queue_ms": 16,
            "tunnel_secs": 16
          }
        }
      }
    }
  }
}
```

