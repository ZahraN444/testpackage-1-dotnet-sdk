
# Api Key

An API key resource

## Structure

`ApiKey`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Id` | `string` | Required | A 24 character hex string used to identify a unique resource. |
| `HubId` | `string` | Required | The unique ID of the Hub this resource was created in. |
| `Name` | `string` | Required | A name for the API key. |
| `Creator` | [`CreatorScope`](../../doc/models/creator-scope.md) | Required | The creator scope is embedded in resource objects to describe who created them |
| `Secret` | `string` | Required | The API key secret. |
| `Permissions` | [`Permissions1`](../../doc/models/permissions-1.md) | Required | Information about this members permissions for a given resource. |
| `Capabilities` | [`Capabilities7`](../../doc/models/capabilities-7.md) | Required | An object holding information about the capabilities of this API key. |
| `Ips` | `List<string>` | Required | An array of IP's this API key can make calls from. |
| `State` | [`ApiKeyState`](../../doc/models/api-key-state.md) | Required | - |
| `Events` | [`HubEvents1`](../../doc/models/hub-events-1.md) | Required | A collection of timestamps for each event in the hub's lifetime. |

## Example (as JSON)

```json
{
  "id": "651586fca6078e98982dbd90",
  "hub_id": "651586fca6078e98982dbd90",
  "name": "name2",
  "creator": {
    "id": "651586fca6078e98982dbd90",
    "type": "employee"
  },
  "secret": "secret8",
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
    "ips6",
    "ips7"
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
```

