
# Health

information about the health of the instance.

## Structure

`Health`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Healthy` | `bool?` | Required | Describes the healthiness of the instance. Health checks can be configured at the container level.<br><br>- `true`: The instance is considered healthy.<br>- `false`: The instance is considered unhealthy.<br>- `null`: The instance has not yet reported its health, or a health check has not yet been performed. |
| `Updated` | `DateTime` | Required | A timestamp of the last time the instance health was updated. |

## Example (as JSON)

```json
{
  "healthy": false,
  "updated": "01/30/2021 08:30:00"
}
```

