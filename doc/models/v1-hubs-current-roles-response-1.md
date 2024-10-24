
# V1 Hubs Current Roles Response 1

## Structure

`V1HubsCurrentRolesResponse1`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Data` | [`Role`](../../doc/models/role.md) | Required | A Role is a custom combination of platform-level capabilities, allowing for fully customizable role-based access controls across the platform. |

## Example (as JSON)

```json
{
  "data": {
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
}
```

