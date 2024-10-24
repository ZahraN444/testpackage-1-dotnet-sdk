
# Provisioning

Information about the provisioning of the server.

## Structure

`Provisioning`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Started` | `DateTime` | Required | A timestamp of when the server started provisioning. |
| `Failed` | `DateTime` | Required | A timestamp of when the server failed provisioning. |
| `Completed` | `DateTime` | Required | A timestamp of when the server completed provisioning. |

## Example (as JSON)

```json
{
  "started": "01/30/2021 08:30:00",
  "failed": "01/30/2021 08:30:00",
  "completed": "01/30/2021 08:30:00"
}
```

