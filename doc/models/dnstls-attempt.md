
# DNSTLS Attempt

A DNS TLS certificate generation attempt resource.

## Structure

`DNSTLSAttempt`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Id` | `string` | Required | A 24 character hex string used to identify a unique resource. |
| `HubId` | `string` | Required | The unique ID of the Hub this resource was created in. |
| `Domains` | `List<string>` | Required | A list of domains associated with the attempt. |
| `Time` | `DateTime` | Required | A timestamp for when the attempt took place. |
| `Success` | `bool` | Required | A boolean where true means the attept was successful at creating the TLS certificate. |
| `Error` | `string` | Optional | If success is false this property will be populated with an error. |

## Example (as JSON)

```json
{
  "id": "651586fca6078e98982dbd90",
  "hub_id": "651586fca6078e98982dbd90",
  "domains": [
    "domains0",
    "domains1"
  ],
  "time": "01/30/2021 08:30:00",
  "success": false,
  "error": "error4"
}
```

