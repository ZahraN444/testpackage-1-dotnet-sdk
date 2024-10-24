
# Connections

Defines extra configuration options connections to the load balancer

## Structure

`Connections`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `MaxIdleConnsPerConnection` | `int?` | Required | Maximum number of simultaneous connections (via http/2) per connection. |

## Example (as JSON)

```json
{
  "max_idle_conns_per_connection": 44
}
```

