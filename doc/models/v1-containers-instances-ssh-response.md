
# V1 Containers Instances Ssh Response

## Structure

`V1ContainersInstancesSshResponse`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Data` | [`SSHConnectionResponse`](../../doc/models/ssh-connection-response.md) | Required | SSH connection information for a given container instance. |

## Example (as JSON)

```json
{
  "data": {
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
    "secret": "secret6",
    "address": "address6"
  }
}
```

