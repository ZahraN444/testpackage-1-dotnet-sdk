
# Timeouts 1

Various options for handling timeouts when communicating with a container instance behind the load balancer.

## Structure

`Timeouts1`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `ServerSecs` | `int?` | Required | The number of seconds the load balancer will wait for a response from the container instance. See the [HAProxy Docs](https://cbonte.github.io/haproxy-dconv/1.7/configuration.html#4.2-timeout%20server) for more information. |
| `ServerFinMs` | `int?` | Required | The number of milliseconds the load balancer will wait for the server to send data when one direction is already closed. See the [HAProxy Docs](https://cbonte.github.io/haproxy-dconv/1.7/configuration.html#4-timeout%20server-fin) for more information. |
| `ConnectMs` | `int?` | Required | The number of milliseconds the load balancer will wait for a successful connection to a container instance. See the [HAProxy Docs](https://cbonte.github.io/haproxy-dconv/1.7/configuration.html#4-timeout%20connect) for more information. |
| `QueueMs` | `int?` | Required | The number of milliseconds the load balancer will hold connections in a queue when the maximum number of connections has been reached. See the [HAProxy Docs](https://cbonte.github.io/haproxy-dconv/1.7/configuration.html#4-timeout%20queue) for more information. |
| `TunnelSecs` | `int?` | Required | The number of milliseconds the load balancer will allow for inactivity on a bidirectional tunnel. See the [HAProxy Docs](https://cbonte.github.io/haproxy-dconv/1.7/configuration.html#4-timeout%20tunnel) for more information. |

## Example (as JSON)

```json
{
  "server_secs": 186,
  "server_fin_ms": 140,
  "connect_ms": 68,
  "queue_ms": 2,
  "tunnel_secs": 2
}
```

