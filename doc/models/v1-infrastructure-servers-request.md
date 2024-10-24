
# V1 Infrastructure Servers Request

## Structure

`V1InfrastructureServersRequest`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Cluster` | `string` | Required | The existing or new cluster this infrastructure should be provisioned in. |
| `Servers` | [`List<Servers1>`](../../doc/models/servers-1.md) | Required | An array of servers to provision. |

## Example (as JSON)

```json
{
  "cluster": "cluster2",
  "servers": [
    {
      "integration_id": "651586fca6078e98982dbd90",
      "model_id": "model_id2",
      "location_id": "location_id6",
      "quantity": 238,
      "hostnames": [
        "hostnames0"
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
  ]
}
```

