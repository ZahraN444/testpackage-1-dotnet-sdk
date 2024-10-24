
# DNS Zone

DNS (Domain Name System), in short, is a decentralized naming system for computers, services, or other resources connected to the internet or a private network. It is what allows the translation of a URL, such as http://example.com, to an IP address.

## Structure

`DNSZone`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Id` | `string` | Required | A 24 character hex string used to identify a unique resource. |
| `HubId` | `string` | Required | The unique ID of the Hub this resource was created in. |
| `Creator` | [`CreatorScope`](../../doc/models/creator-scope.md) | Required | The creator scope is embedded in resource objects to describe who created them |
| `Origin` | `string` | Required | The origin for the given DNS zone. |
| `Hosted` | `bool` | Required | A boolean where true represents this zone is a hosted zone. |
| `State` | [`DNSZoneState`](../../doc/models/dns-zone-state.md) | Required | - |
| `Events` | [`ZoneEvents`](../../doc/models/zone-events.md) | Required | A collection of timestamps for each event in the DNS zone's lifetime. |

## Example (as JSON)

```json
{
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
```

