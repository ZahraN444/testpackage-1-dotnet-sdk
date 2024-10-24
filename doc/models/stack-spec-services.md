
# Stack Spec Services

## Structure

`StackSpecServices`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Discovery` | [`Discovery2`](../../doc/models/discovery-2.md) | Optional | - |
| `Loadbalancer` | [`StackSpecServicesLoadbalancer`](../../doc/models/containers/stack-spec-services-loadbalancer.md) | Optional | This is a container for any-of cases. |
| `Vpn` | [`Vpn2`](../../doc/models/vpn-2.md) | Optional | - |

## Example (as JSON)

```json
{
  "discovery": {
    "hosts": {
      "key0": {
        "ipv4": [
          "ipv42",
          "ipv43"
        ],
        "ipv6": [
          "ipv66",
          "ipv67",
          "ipv68"
        ]
      },
      "key1": {
        "ipv4": [
          "ipv42",
          "ipv43"
        ],
        "ipv6": [
          "ipv66",
          "ipv67",
          "ipv68"
        ]
      },
      "key2": {
        "ipv4": [
          "ipv42",
          "ipv43"
        ],
        "ipv6": [
          "ipv66",
          "ipv67",
          "ipv68"
        ]
      }
    }
  },
  "loadbalancer": {
    "type": "haproxy",
    "ipv4": false,
    "ipv6": false,
    "details": {
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
  },
  "vpn": {
    "auth": {
      "webhook": "webhook4",
      "cycle_accounts": false,
      "vpn_accounts": false
    },
    "allow_internet": false
  }
}
```

