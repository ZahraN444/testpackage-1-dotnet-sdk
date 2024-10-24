
# Frontend

Settings that describe how incoming traffic to the load balancer is handled.

## Structure

`Frontend`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Mode` | [`ModeEnum`](../../doc/models/mode-enum.md) | Required | The type of traffic expected by the load balancer for this port. Can be either:<br><br>- tcp: Traffic is forwarded without any parsing or additional manipulation.<br>- http: Traffic is treated as web traffic. If a LINKED record is configured for a container exposing this port, the domain will be parsed and it will be forwarded to the proper container. This allows multiple services to run on port 80 in the same environment. |
| `MaxConnections` | `int?` | Required | The number of simultaneous connections that can be processed at a time. |
| `Timeouts` | [`Timeouts`](../../doc/models/timeouts.md) | Required | Various options for handling timeouts when communicating with the client. |

## Example (as JSON)

```json
{
  "mode": "tcp",
  "max_connections": 200,
  "timeouts": {
    "client_secs": 228,
    "client_fin_ms": 250,
    "http_keep_alive_ms": 122,
    "http_request_ms": 102
  }
}
```

