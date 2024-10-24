
# V1 Hubs Current Invites Request

## Structure

`V1HubsCurrentInvitesRequest`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Recipient` | `string` | Optional | The email address of the invitee. |
| `RoleId` | `string` | Optional | The account role. |
| `Permissions` | [`Permissions2`](../../doc/models/permissions-2.md) | Optional | The Environment permissions the invitee will have |

## Example (as JSON)

```json
{
  "role_id": "651586fca6078e98982dbd90",
  "recipient": "recipient2",
  "permissions": {
    "all_environments": false,
    "environments": [
      {
        "id": "id2",
        "manage": false
      }
    ]
  }
}
```

