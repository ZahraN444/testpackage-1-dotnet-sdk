
# Certificate Events

A collection of timestamps for each event in the certificate's lifetime.

## Structure

`CertificateEvents`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Created` | `DateTime?` | Optional | [unused] |
| `Updated` | `DateTime?` | Optional | [unused] |
| `Deleted` | `DateTime?` | Optional | [unused] |
| `Generated` | `DateTime?` | Optional | When the certificate was generated; useful for calculating expiration (+90 days) |

## Example (as JSON)

```json
{
  "created": "01/30/2021 08:30:00",
  "updated": "01/30/2021 08:30:00",
  "deleted": "01/30/2021 08:30:00",
  "generated": "01/30/2021 08:30:00"
}
```

