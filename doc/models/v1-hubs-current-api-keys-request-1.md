
# V1 Hubs Current Api Keys Request 1

## Structure

`V1HubsCurrentApiKeysRequest1`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Name` | `string` | Optional | A name given to the API Key. |
| `Permissions` | [`Permissions`](../../doc/models/permissions.md) | Optional | Permissions information for an API Key |
| `Capabilities` | [`Capabilities9`](../../doc/models/capabilities-9.md) | Optional | - |
| `Ips` | `List<string>` | Optional | An array of approved IPs from which this API Key can be used. |

## Example (as JSON)

```json
{
  "name": "name2",
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
    "ips6",
    "ips7",
    "ips8"
  ]
}
```

