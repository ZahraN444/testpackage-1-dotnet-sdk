
# Hub Events

A collection of timestamps for each event in the hub's lifetime.

## Structure

`HubEvents`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Created` | `DateTime` | Required | The timestamp of when the hub was created. |
| `Updated` | `DateTime` | Required | The timestamp of when the hub was updated. |
| `Deleted` | `DateTime` | Required | The timestamp of when the hub was deleted. |
| `Converted` | `DateTime?` | Optional | The timestamp of when the hub had the first converted. |
| `FirstOrder` | `DateTime?` | Optional | The timestamp of when the hub had the first provider added. |
| `FirstProvider` | `DateTime?` | Optional | The timestamp of when the hub had the first provider added. |
| `FirstServer` | `DateTime?` | Optional | The timestamp of when the hub had the first_server deployed. |
| `FirstEnvironment` | `DateTime?` | Optional | The timestamp of when the hub had the first environment deployed. |
| `FirstImage` | `DateTime?` | Optional | The timestamp of when the hub had the first image deployed. |
| `FirstContainer` | `DateTime?` | Optional | The timestamp of when the hub had the first container deployed. |

## Example (as JSON)

```json
{
  "created": "01/30/2021 08:30:00",
  "updated": "01/30/2021 08:30:00",
  "deleted": "01/30/2021 08:30:00",
  "converted": "01/30/2021 08:30:00",
  "first_order": "01/30/2021 08:30:00",
  "first_provider": "01/30/2021 08:30:00",
  "first_server": "01/30/2021 08:30:00",
  "first_environment": "01/30/2021 08:30:00",
  "first_image": "01/30/2021 08:30:00",
  "first_container": "01/30/2021 08:30:00"
}
```

