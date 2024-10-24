
# Auto Scale Group Infrastructure

## Structure

`AutoScaleGroupInfrastructure`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Models` | [`List<Model>`](../../doc/models/model.md) | Required | - |

## Example (as JSON)

```json
{
  "models": [
    {
      "provider": "provider4",
      "integration_id": "651586fca6078e98982dbd90",
      "model_id": "model_id4",
      "priority": 54,
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
  ]
}
```

