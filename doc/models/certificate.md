
# Certificate

A DNS TLS certificate.

## Structure

`Certificate`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Id` | `string` | Required | A 24 character hex string used to identify a unique resource. |
| `HubId` | `string` | Required | The unique ID of the Hub this resource was created in. |
| `Domains` | `List<string>` | Required | A list of domains associated with the certificate. |
| `Events` | [`CertificateEvents`](../../doc/models/certificate-events.md) | Required | A collection of timestamps for each event in the certificate's lifetime. |
| `Bundle` | `string` | Required | The certificate bundle |
| `PrivateKey` | `string` | Required | The private key for the certificate |

## Example (as JSON)

```json
{
  "id": "651586fca6078e98982dbd90",
  "hub_id": "651586fca6078e98982dbd90",
  "domains": [
    "domains0"
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
```

