
# Servers 1

## Structure

`Servers1`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `IntegrationId` | `string` | Required | The ID of the provider integration to use for this Server. |
| `ModelId` | `string` | Required | The model ID of the Server. |
| `LocationId` | `string` | Required | The location ID of the Server. |
| `Quantity` | `int` | Required | The number of this Server at this location to deploy. |
| `Hostnames` | `List<string>` | Optional | An array of hostnames for the given servers. |
| `Advanced` | [`List<Advanced>`](../../doc/models/advanced.md) | Optional | - |

## Example (as JSON)

```json
{
  "integration_id": "651586fca6078e98982dbd90",
  "model_id": "model_id4",
  "location_id": "location_id8",
  "quantity": 248,
  "hostnames": [
    "hostnames2"
  ],
  "advanced": [
    {
      "provision_options": {
        "attached_storage_size": 108.26,
        "reservation_id": "reservation_id8"
      },
      "zone": "zone4"
    },
    {
      "provision_options": {
        "attached_storage_size": 108.26,
        "reservation_id": "reservation_id8"
      },
      "zone": "zone4"
    }
  ]
}
```

