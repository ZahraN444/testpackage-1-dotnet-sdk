
# Instance Auto Scale

Auto-scale details for instances created by auto-scale events.

## Structure

`InstanceAutoScale`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `SiblingId` | `string` | Required | A 24 character hex string used to identify a unique resource. |
| `MinTtl` | `DateTime` | Required | - |

## Example (as JSON)

```json
{
  "sibling_id": "651586fca6078e98982dbd90",
  "min_ttl": "01/30/2021 08:30:00"
}
```

