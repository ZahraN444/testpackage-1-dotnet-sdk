
# Role

A Role is a custom combination of platform-level capabilities, allowing for fully customizable role-based access controls across the platform.

## Structure

`Role`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Id` | `string` | Required | - |
| `Name` | `string` | Optional | - |
| `Root` | `bool` | Required | The Role marked as root has full moderation control over all Roles. |
| `Default` | [`RoleDefault`](../../doc/models/containers/role-default.md) | Optional | This is a container for any-of cases. |
| `Rank` | `int` | Required | An integer between 0 and 10 that indicates the Role hierarchy. An account can only edit a Role that is less than their rank. The 'owner' Role is rank 10. |
| `Identifier` | `string` | Required | A human-readable identifier used to refer to a resource, where using the official ID may be inconvenient.<br>The identifier is automatically tokenized from the name/relevant field of the resource if one is not provided. For example, a container named "My Container" will<br>have the identifier of `my-container` and is automatically created by the platform.<br><br>The identifier does not have to be unique. |
| `Creator` | [`CreatorScope`](../../doc/models/creator-scope.md) | Required | The creator scope is embedded in resource objects to describe who created them |
| `Capabilities` | [`Capabilities1`](../../doc/models/capabilities-1.md) | Required | The list of platform level capabilities assigned to this Role. |
| `Extra` | `Dictionary<string, string>` | Optional | Custom user-defined properties for storing extra information on the Role. Not utilized by Cycle. |
| `HubId` | `string` | Required | The unique ID of the Hub this resource was created in. |
| `State` | [`State1`](../../doc/models/state-1.md) | Required | - |
| `Events` | [`RoleEvents`](../../doc/models/role-events.md) | Required | Timestamps for each event in the Role's lifetime. |

## Example (as JSON)

```json
{
  "id": "id6",
  "root": false,
  "rank": 84,
  "identifier": "identifier6",
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
  "name": "name6",
  "default": "String7",
  "extra": {
    "key0": "extra8",
    "key1": "extra7",
    "key2": "extra6"
  }
}
```

