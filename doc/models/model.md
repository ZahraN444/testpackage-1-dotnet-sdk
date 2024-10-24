
# Model

## Structure

`Model`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Provider` | `string` | Required | The integration identifier for infrastructure provider used. |
| `IntegrationId` | `string` | Optional | The ID of the integration associated with this auto-scale group infrastructure. |
| `ModelId` | `string` | Required | - |
| `Priority` | `int` | Required | - |
| `Locations` | [`List<Location>`](../../doc/models/location.md) | Required | - |

## Example (as JSON)

```json
{
  "provider": "provider0",
  "integration_id": "651586fca6078e98982dbd90",
  "model_id": "model_id8",
  "priority": 68,
  "locations": [
    {
      "id": "id8",
      "availability_zones": [
        "availability_zones5",
        "availability_zones6",
        "availability_zones7"
      ]
    }
  ]
}
```

