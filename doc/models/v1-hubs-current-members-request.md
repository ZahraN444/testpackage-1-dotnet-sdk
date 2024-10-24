
# V1 Hubs Current Members Request

## Structure

`V1HubsCurrentMembersRequest`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `RoleId` | `string` | Optional | The account role. |
| `Permissions` | [`Permissions`](../../doc/models/permissions.md) | Optional | Permissions information for an API Key |

## Example (as JSON)

```json
{
  "role_id": "651586fca6078e98982dbd90",
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

