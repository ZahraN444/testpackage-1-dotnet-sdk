
# Api Key Creator

An extended resource that has information on a Cycle hub API key

## Structure

`ApiKeyCreator`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Id` | `string` | Required | A 24 character hex string used to identify a unique resource. |
| `Name` | `string` | Required | The name of the API key |
| `HubId` | `string` | Required | A 24 character hex string used to identify a unique resource. |
| `Secret` | `string` | Optional | The API key secret |
| `Permissions` | [`Permissions`](../../doc/models/permissions.md) | Required | Permissions information for an API Key |
| `Capabilities` | [`Capabilities2`](../../doc/models/capabilities-2.md) | Required | The API key capabilities list |
| `Ips` | `List<string>` | Required | - |
| `State` | [`State6`](../../doc/models/state-6.md) | Required | - |
| `Events` | `Dictionary<string, DateTime>` | Required | Describes the date and time at which certain events occurred in the lifetime of this resource. |

## Example (as JSON)

```json
{
  "id": "651586fca6078e98982dbd90",
  "name": "name0",
  "hub_id": "651586fca6078e98982dbd90",
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
      "specific4"
    ]
  },
  "ips": [
    "ips4"
  ],
  "state": {
    "current": "deleted",
    "changed": "01/30/2021 08:30:00",
    "error": {
      "message": "message4",
      "time": "2016-03-13T12:52:32.123Z"
    }
  },
  "events": {
    "key0": "2016-03-13T12:52:32.123Z",
    "key1": "2016-03-13T12:52:32.123Z"
  },
  "secret": "secret6"
}
```

