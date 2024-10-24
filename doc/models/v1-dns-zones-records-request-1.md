
# V1 Dns Zones Records Request 1

## Structure

`V1DnsZonesRecordsRequest1`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Type` | [`DNSRecordTypes`](../../doc/models/dns-record-types.md) | Required | DNS record types the platform supports. |

## Example (as JSON)

```json
{
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
  }
}
```

