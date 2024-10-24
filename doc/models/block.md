
# Block

Network information about the pool.

## Structure

`Block`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Cidr` | `string` | Required | A cidr for the pool. |
| `Gateway` | `string` | Required | A gateway for the pool. |
| `Netmask` | `string` | Required | A netmask for the pool. |
| `Network` | `string` | Required | A network for the pool. |

## Example (as JSON)

```json
{
  "cidr": "cidr6",
  "gateway": "gateway6",
  "netmask": "netmask6",
  "network": "network8"
}
```

