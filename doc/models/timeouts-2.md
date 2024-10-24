
# Timeouts 2

Defines how the length of various sorts of timeouts when communicating with the destination.

## Structure

`Timeouts2`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `DestinationConnection` | `string` | Required | The duration the load balancer will wait before timing out while attempting to connect to the destination. |

## Example (as JSON)

```json
{
  "destination_connection": "72h45m2s"
}
```

