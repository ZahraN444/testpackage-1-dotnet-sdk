
# V1 Infrastructure Ips Pools Ips Response

## Structure

`V1InfrastructureIpsPoolsIpsResponse`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Data` | [`List<IP>`](../../doc/models/ip.md) | Required | - |

## Example (as JSON)

```json
{
  "data": [
    {
      "id": "651586fca6078e98982dbd90",
      "hub_id": "651586fca6078e98982dbd90",
      "kind": "ipv4",
      "pool_id": "pool_id2",
      "address": "address6",
      "gateway": "gateway0",
      "cidr": "cidr0",
      "state": {
        "current": "releasing",
        "changed": "01/30/2021 08:30:00",
        "error": {
          "message": "message4",
          "time": "2016-03-13T12:52:32.123Z"
        }
      },
      "assignment": {
        "container_id": "container_id2",
        "instance_id": "instance_id4",
        "environment_id": "environment_id4"
      }
    }
  ]
}
```

