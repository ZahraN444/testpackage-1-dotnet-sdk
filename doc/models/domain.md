
# Domain

Any associated Linked Records for this container, and their fully-qualified domain name (fqdn)

## Structure

`Domain`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Fqdn` | `string` | Required | The fully qualified domain name. |
| `Record` | [`DNSRecord`](../../doc/models/dns-record.md) | Optional | A DNS record. |

## Example (as JSON)

```json
{
  "fqdn": "fqdn6",
  "record": {
    "id": "id0",
    "hub_id": "hub_id2",
    "creator": {
      "id": "id8",
      "type": "employee"
    },
    "zone_id": "zone_id6",
    "name": "name0",
    "resolved_domain": "resolved_domain6",
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
        "id": "id8",
        "generated": "2016-03-13T12:52:32.123Z",
        "wildcard_child": false
      }
    },
    "state": {
      "current": "deleting",
      "changed": "2016-03-13T12:52:32.123Z",
      "error": {
        "message": "message4",
        "time": "2016-03-13T12:52:32.123Z"
      }
    },
    "events": {
      "key0": "2016-03-13T12:52:32.123Z",
      "key1": "2016-03-13T12:52:32.123Z",
      "key2": "2016-03-13T12:52:32.123Z"
    }
  }
}
```

