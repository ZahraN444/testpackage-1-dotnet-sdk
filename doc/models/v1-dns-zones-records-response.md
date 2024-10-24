
# V1 Dns Zones Records Response

## Structure

`V1DnsZonesRecordsResponse`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Data` | [`DNSRecord`](../../doc/models/dns-record.md) | Required | A DNS record. |

## Example (as JSON)

```json
{
  "data": {
    "id": "651586fca6078e98982dbd90",
    "hub_id": "651586fca6078e98982dbd90",
    "creator": {
      "id": "651586fca6078e98982dbd90",
      "type": "employee"
    },
    "zone_id": "zone_id6",
    "name": "name0",
    "resolved_domain": "resolved_domain4",
    "type": {
      "a": {
        "ip": "ip6"
      },
      "aaaa": {
        "ip": "ip6"
      },
      "cname": {
        "domain": "domain4"
      },
      "ns": {
        "domain": "domain8"
      },
      "mx": {
        "priority": 20,
        "domain": "domain4"
      }
    },
    "features": {
      "certificate": {
        "id": "651586fca6078e98982dbd90",
        "generated": "01/30/2021 08:30:00",
        "wildcard_child": false
      }
    },
    "state": {
      "current": "deleting",
      "changed": "01/30/2021 08:30:00",
      "error": {
        "message": "message4",
        "time": "2016-03-13T12:52:32.123Z"
      }
    },
    "events": {
      "key0": "2016-03-13T12:52:32.123Z",
      "key1": "2016-03-13T12:52:32.123Z"
    }
  }
}
```

