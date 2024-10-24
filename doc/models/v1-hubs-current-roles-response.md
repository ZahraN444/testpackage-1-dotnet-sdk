
# V1 Hubs Current Roles Response

## Structure

`V1HubsCurrentRolesResponse`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Data` | [`List<Role>`](../../doc/models/role.md) | Required | - |

## Example (as JSON)

```json
{
  "data": [
    {
      "id": "id0",
      "root": false,
      "rank": 228,
      "identifier": "identifier8",
      "creator": {
        "id": "651586fca6078e98982dbd90",
        "type": "employee"
      },
      "capabilities": {
        "all": false,
        "specific": [
          "pipelines-view"
        ]
      },
      "hub_id": "651586fca6078e98982dbd90",
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
      },
      "name": "name0",
      "default": "String1",
      "extra": {
        "key0": "extra4",
        "key1": "extra3",
        "key2": "extra2"
      }
    }
  ]
}
```

