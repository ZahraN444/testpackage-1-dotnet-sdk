
# Get VPN Users Return

## Structure

`GetVPNUsersReturn`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Data` | [`List<VPNUser>`](../../doc/models/vpn-user.md) | Required | - |

## Example (as JSON)

```json
{
  "data": [
    {
      "id": "651586fca6078e98982dbd90",
      "username": "username0",
      "creator": {
        "id": "651586fca6078e98982dbd90",
        "type": "employee"
      },
      "last_login": "01/30/2021 08:30:00",
      "hub_id": "651586fca6078e98982dbd90",
      "environment_id": "environment_id8",
      "events": {
        "created": "01/30/2021 08:30:00",
        "updated": "01/30/2021 08:30:00",
        "deleted": "01/30/2021 08:30:00"
      }
    }
  ]
}
```

