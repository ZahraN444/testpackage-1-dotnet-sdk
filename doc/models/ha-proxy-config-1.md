
# Ha Proxy Config 1

Describes settings that are passed to HAProxy within the load balancer.

## Structure

`HaProxyConfig1`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Default` | [`HAProxyConfig2`](../../doc/models/ha-proxy-config-2.md) | Required | Settings that are applied to any port that is not overridden in the following ports section. |
| `Ports` | [`Dictionary<string, HAProxyConfig>`](../../doc/models/ha-proxy-config.md) | Required | An object that defines how HAProxy will act on a specific port. The key is a custom port, and the value is the same settings object found under `default` above. |

## Example (as JSON)

```json
{
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
```

