
# Server Events

A collection of timestamps for each event in the server's lifetime.

## Structure

`ServerEvents`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Created` | `DateTime` | Required | The timestamp of when the server was created. |
| `Updated` | `DateTime` | Required | The timestamp of when the server was updated. |
| `Deleted` | `DateTime` | Required | The timestamp of when the server was deleted. |
| `LatestInstance` | `DateTime` | Required | The timestamp of when the latest instance was deployed to this server. |
| `Provisioning` | [`Provisioning`](../../doc/models/provisioning.md) | Required | Information about the provisioning of the server. |

## Example (as JSON)

```json
{
  "created": "01/30/2021 08:30:00",
  "updated": "01/30/2021 08:30:00",
  "deleted": "01/30/2021 08:30:00",
  "latest_instance": "01/30/2021 08:30:00",
  "provisioning": {
    "started": "01/30/2021 08:30:00",
    "failed": "01/30/2021 08:30:00",
    "completed": "01/30/2021 08:30:00"
  }
}
```

