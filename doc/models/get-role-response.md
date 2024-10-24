
# Get Role Response

## Structure

`GetRoleResponse`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Data` | [`Role`](../../doc/models/role.md) | Optional | A Role is a custom combination of platform-level capabilities, allowing for fully customizable role-based access controls across the platform. |

## Example (as JSON)

```json
{
  "data": {
    "id": "id0",
    "name": "name0",
    "root": false,
    "default": "String1",
    "rank": 228,
    "identifier": "identifier8",
    "creator": {
      "id": "id8",
      "type": "employee"
    },
    "capabilities": {
      "all": false,
      "specific": [
        "pipelines-view"
      ]
    },
    "extra": {
      "key0": "extra4",
      "key1": "extra3",
      "key2": "extra2"
    },
    "hub_id": "hub_id2",
    "state": {
      "current": "current2",
      "changed": "2016-03-13T12:52:32.123Z",
      "error": {
        "message": "message4",
        "time": "2016-03-13T12:52:32.123Z"
      }
    },
    "events": {
      "created": "2016-03-13T12:52:32.123Z",
      "updated": "2016-03-13T12:52:32.123Z",
      "deleted": "2016-03-13T12:52:32.123Z"
    }
  }
}
```

