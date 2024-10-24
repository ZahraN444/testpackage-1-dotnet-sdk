
# List Api Keys Response

## Structure

`ListApiKeysResponse`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Data` | [`List<ApiKey>`](../../doc/models/api-key.md) | Required | - |

## Example (as JSON)

```json
{
  "data": [
    {
      "id": "651586fca6078e98982dbd90",
      "hub_id": "651586fca6078e98982dbd90",
      "name": "name0",
      "creator": {
        "id": "651586fca6078e98982dbd90",
        "type": "employee"
      },
      "secret": "secret6",
      "permissions": {
        "all_environments": false,
        "environments": [
          {
            "id": "651586fca6078e98982dbd90",
            "manage": false
          }
        ]
      },
      "capabilities": {
        "all": false,
        "specific": [
          "pipelines-view"
        ]
      },
      "ips": [
        "ips4",
        "ips5",
        "ips6"
      ],
      "state": {
        "current": "live",
        "changed": "01/30/2021 08:30:00",
        "error": {
          "message": "message4",
          "time": "2016-03-13T12:52:32.123Z"
        }
      },
      "events": {
        "created": "01/30/2021 08:30:00",
        "updated": "01/30/2021 08:30:00",
        "deleted": "01/30/2021 08:30:00"
      }
    }
  ]
}
```

