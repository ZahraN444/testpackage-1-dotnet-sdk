
# Backend

Settings related to how the load balancer routes connections to container instances.

## Structure

`Backend`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Balance` | [`BalanceEnum`](../../doc/models/balance-enum.md) | Required | How connections are balanced across your container instances. Can be one of the following:<br><br>- `roundrobin`: Each container instance is used in turns.<br>- `static-rr`: Each container instance is used in turns, but is faster than Round Robin at the expense of being less dynamic.<br>- `leastconn`: Routes traffic to the instance with the least number of active connections.<br>- `first`: Routes traffic to the first available instance.<br>- `source`: The same client IP always reaches the same container instance as long as no instance goes down or up. |
| `Timeouts` | [`Timeouts1`](../../doc/models/timeouts-1.md) | Required | Various options for handling timeouts when communicating with a container instance behind the load balancer. |

## Example (as JSON)

```json
{
  "balance": "first",
  "timeouts": {
    "server_secs": 200,
    "server_fin_ms": 126,
    "connect_ms": 174,
    "queue_ms": 16,
    "tunnel_secs": 16
  }
}
```

