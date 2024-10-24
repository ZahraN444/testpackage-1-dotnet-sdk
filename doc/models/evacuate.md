
# Evacuate

Details about a server's evacuation status. When an evacuation is in progress, no new container instances will be permitted on the server.

## Structure

`Evacuate`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Started` | `DateTime` | Required | The time when this server began evacuating instances. |

## Example (as JSON)

```json
{
  "started": "01/30/2021 08:30:00"
}
```

