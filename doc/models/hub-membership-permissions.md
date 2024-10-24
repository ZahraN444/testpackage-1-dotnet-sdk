
# Hub Membership Permissions

Information about this member's permissions for a given hub.

## Structure

`HubMembershipPermissions`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `AllEnvironments` | `bool` | Required | A boolean where true represents the member has access to view and manage all environments for the hub. |
| `Environments` | [`List<Environment4>`](../../doc/models/environment-4.md) | Required | An array of environments this membership has access to. |

## Example (as JSON)

```json
{
  "all_environments": false,
  "environments": [
    {
      "id": "651586fca6078e98982dbd90",
      "manage": false
    }
  ]
}
```

