
# DNS Record

A DNS record.

## Structure

`DNSRecord`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Id` | `string` | Required | A 24 character hex string used to identify a unique resource. |
| `HubId` | `string` | Required | The unique ID of the Hub this resource was created in. |
| `Creator` | [`CreatorScope`](../../doc/models/creator-scope.md) | Required | The creator scope is embedded in resource objects to describe who created them |
| `ZoneId` | `string` | Required | A unique identifier for the zone |
| `Name` | `string` | Required | A name used for the record, where `@` signifies the use of the root domain. |
| `ResolvedDomain` | `string` | Required | The name of the record and the origin as a domain name. |
| `Type` | [`DNSRecordTypes`](../../doc/models/dns-record-types.md) | Required | DNS record types the platform supports. |
| `Features` | [`Features2`](../../doc/models/features-2.md) | Required | TLS features for the record. |
| `State` | [`DNSRecordState`](../../doc/models/dns-record-state.md) | Required | - |
| `Events` | `Dictionary<string, DateTime>` | Required | Describes the date and time at which certain events occurred in the lifetime of this resource. |

## Example (as JSON)

```json
{
  "id": "651586fca6078e98982dbd90",
  "hub_id": "651586fca6078e98982dbd90",
  "creator": {
    "id": "651586fca6078e98982dbd90",
    "type": "employee"
  },
  "zone_id": "zone_id8",
  "name": "name2",
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
    "key0": "2016-03-13T12:52:32.123Z"
  }
}
```

