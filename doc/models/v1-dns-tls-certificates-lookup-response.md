
# V1 Dns Tls Certificates Lookup Response

## Structure

`V1DnsTlsCertificatesLookupResponse`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Data` | [`Certificate`](../../doc/models/certificate.md) | Required | A DNS TLS certificate. |

## Example (as JSON)

```json
{
  "data": {
    "id": "651586fca6078e98982dbd90",
    "hub_id": "651586fca6078e98982dbd90",
    "domains": [
      "domains0",
      "domains1",
      "domains2"
    ],
    "events": {
      "created": "01/30/2021 08:30:00",
      "updated": "01/30/2021 08:30:00",
      "deleted": "01/30/2021 08:30:00",
      "generated": "01/30/2021 08:30:00"
    },
    "bundle": "bundle6",
    "private_key": "private_key4"
  }
}
```

