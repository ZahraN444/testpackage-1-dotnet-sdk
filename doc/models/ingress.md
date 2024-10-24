
# Ingress

Defines how traffic gets into the load balancer.

## Structure

`Ingress`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Port` | `int` | Required | The port inbound trafic is accepted on. |
| `Tls` | [`Tls1`](../../doc/models/tls-1.md) | Optional | - |

## Example (as JSON)

```json
{
  "port": 26,
  "tls": {
    "enable": false
  }
}
```

