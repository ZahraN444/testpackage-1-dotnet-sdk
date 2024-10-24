
# V1 Hubs Current Api Keys Request

## Structure

`V1HubsCurrentApiKeysRequest`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Name` | `string` | Optional | A name given to the API Key. |
| `Permissions` | [`Permissions`](../../doc/models/permissions.md) | Optional | Permissions information for an API Key |
| `Capabilities` | [`Capabilities8`](../../doc/models/capabilities-8.md) | Optional | An object defining the capabilities of the given API key. |
| `Ips` | `List<string>` | Optional | An array of approved IPs from which this API Key can be used. |

## Example (as JSON)

```json
{
  "name": "name0",
  "permissions": {
    "all_environments": false,
    "environments": [
      {
        "id": "id2",
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
    "ips5"
  ]
}
```

