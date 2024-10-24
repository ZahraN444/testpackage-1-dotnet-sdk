
# Timeouts

Various options for handling timeouts when communicating with the client.

## Structure

`Timeouts`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `ClientSecs` | `int?` | Required | The number of seconds the load balancer will wait for a response from a client before disconnecting. |
| `ClientFinMs` | `int?` | Required | The number of milliseconds the load balancer will wait for a client to send it data when one direction is already closed. This is particularly useful to avoid keeping connections in a waiting state for too long when clients do not disconnect cleanly. |
| `HttpKeepAliveMs` | `int?` | Required | The number of milliseconds the load balancer will wait for a new HTTP request to start coming after a response was set. See the [HAProxy Docs](https://cbonte.github.io/haproxy-dconv/1.7/configuration.html#4.2-timeout%20http-request) for more information. (`http` mode only) |
| `HttpRequestMs` | `int?` | Required | The number of milliseconds the load balancer will wait for a complete HTTP request. See the [HAProxy Docs](https://cbonte.github.io/haproxy-dconv/1.7/configuration.html#4.2-timeout%20http-request) for more information. (`http` mode only) |

## Example (as JSON)

```json
{
  "client_secs": 38,
  "client_fin_ms": 184,
  "http_keep_alive_ms": 188,
  "http_request_ms": 168
}
```

