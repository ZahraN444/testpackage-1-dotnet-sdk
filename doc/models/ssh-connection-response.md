
# SSH Connection Response

SSH connection information for a given container instance.

## Structure

`SSHConnectionResponse`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Token` | [`SSHToken`](../../doc/models/ssh-token.md) | Required | An Instance SSH token. |
| `Secret` | `string` | Required | The SSH connection response secret. |
| `Address` | `string` | Required | The SSH connection response address. |

## Example (as JSON)

```json
{
  "token": {
    "id": "651586fca6078e98982dbd90",
    "instance_id": "instance_id6",
    "container_id": "container_id2",
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
  },
  "secret": "secret8",
  "address": "address8"
}
```

