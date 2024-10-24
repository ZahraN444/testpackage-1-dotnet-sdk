
# SSH Token

An Instance SSH token.

## Structure

`SSHToken`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Id` | `string` | Required | A 24 character hex string used to identify a unique resource. |
| `InstanceId` | `string` | Required | The ID of the instance being connected to. |
| `ContainerId` | `string` | Required | The ID of the container from which the instance was created. |
| `HubId` | `string` | Required | The unique ID of the Hub this resource was created in. |
| `Creator` | [`CreatorScope`](../../doc/models/creator-scope.md) | Required | The creator scope is embedded in resource objects to describe who created them |
| `Events` | [`SSHTokenEvents`](../../doc/models/ssh-token-events.md) | Required | A collection of timestamps for each event in the SSH token's lifetime. |
| `Valid` | `bool` | Required | A boolean where true represents the token as being a valid token to be used for connection. |

## Example (as JSON)

```json
{
  "id": "651586fca6078e98982dbd90",
  "instance_id": "instance_id6",
  "container_id": "container_id0",
  "hub_id": "651586fca6078e98982dbd90",
  "creator": {
    "id": "651586fca6078e98982dbd90",
    "type": "employee"
  },
  "events": {
    "created": "01/30/2021 08:30:00",
    "used": "01/30/2021 08:30:00",
    "expires": "01/30/2021 08:30:00"
  },
  "valid": false
}
```

