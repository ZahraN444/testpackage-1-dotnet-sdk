
# V1 Dns Zones Records Request

## Structure

`V1DnsZonesRecordsRequest`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Type` | [`DNSRecordTypes`](../../doc/models/dns-record-types.md) | Required | DNS record types the platform supports. |
| `Name` | `string` | Required | A name for the given record where `@` represents the desire to use the root of the origin. |

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
  },
  "name": "name0"
}
```

