
# Filter 33

## Structure

`Filter33`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `RangeStart` | `DateTime?` | Optional | The start date from when to pull the security report |
| `RangeEnd` | `DateTime?` | Optional | The end date from when to pull the security report |
| `Environment` | `string` | Optional | `filter[environment]=<Environment ID>` fetch the security report for the specified environment |
| `Event` | `string` | Optional | `filter[event]=value` filter by event occurrence. Example: `filter[event]=environment.services.vpn.login` |

## Example (as JSON)

```json
{
  "range-start": "01/30/2021 08:30:00",
  "range-end": "01/30/2021 08:30:00",
  "environment": "environment8",
  "event": "event2"
}
```

