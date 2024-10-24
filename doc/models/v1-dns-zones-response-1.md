
# V1 Dns Zones Response 1

## Structure

`V1DnsZonesResponse1`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Data` | [`DNSZone`](../../doc/models/dns-zone.md) | Required | DNS (Domain Name System), in short, is a decentralized naming system for computers, services, or other resources connected to the internet or a private network. It is what allows the translation of a URL, such as http://example.com, to an IP address. |

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
    "origin": "origin4",
    "hosted": false,
    "state": {
      "current": "verifying",
      "changed": "01/30/2021 08:30:00",
      "error": {
        "message": "message4",
        "time": "2016-03-13T12:52:32.123Z"
      }
    },
    "events": {
      "created": "01/30/2021 08:30:00",
      "updated": "01/30/2021 08:30:00",
      "deleted": "01/30/2021 08:30:00",
      "last_verification": "01/30/2021 08:30:00",
      "verified": "01/30/2021 08:30:00"
    }
  }
}
```

