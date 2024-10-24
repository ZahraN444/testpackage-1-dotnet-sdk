
# DNS Record Types

DNS record types the platform supports.

## Structure

`DNSRecordTypes`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `A` | [`A`](../../doc/models/a.md) | Optional | A DNS A record |
| `Aaaa` | [`Aaaa`](../../doc/models/aaaa.md) | Optional | A DNS AAAA record |
| `Cname` | [`Cname`](../../doc/models/cname.md) | Optional | A DNS CNAME record |
| `Ns` | [`Ns`](../../doc/models/ns.md) | Optional | A DNS NS record |
| `Mx` | [`Mx`](../../doc/models/mx.md) | Optional | A DNS MX record |
| `Txt` | [`Txt`](../../doc/models/txt.md) | Optional | A DNS TXT record. |
| `Alias` | [`Alias`](../../doc/models/alias.md) | Optional | A DNS ALIAS record. |
| `Srv` | [`Srv`](../../doc/models/srv.md) | Optional | A DNS SRV record. |
| `Caa` | [`Caa`](../../doc/models/caa.md) | Optional | A DNS CAA record. |
| `Linked` | [`Linked`](../../doc/models/linked.md) | Optional | A LINKED record is a record special to Cycle.  It represents a URL that points to a specific container or deployment of a container, however the IP address mapping in handled automatically by the platform. |

## Example (as JSON)

```json
{
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
```

