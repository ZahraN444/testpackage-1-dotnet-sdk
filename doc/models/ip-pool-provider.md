
# IP Pool Provider

A IP Pool provider.

## Structure

`IPPoolProvider`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Vendor` | `string` | Required | A vendor for a provider. |
| `IntegrationId` | `string` | Required | ID of the provider integration used to provision the IP. |
| `Location` | `string` | Required | Information about the location of the provider this pool is associated with. |
| `Reservation` | `string` | Required | A reservation identifier associated with the pool reservation. |
| `Server` | `string` | Required | A server identifier associated with the pool. |
| `ServerAssignment` | `string` | Required | An identifier linked to the server assingment of the IP pool. |

## Example (as JSON)

```json
{
  "vendor": "vendor2",
  "integration_id": "651586fca6078e98982dbd90",
  "location": "location0",
  "reservation": "reservation0",
  "server": "server0",
  "server_assignment": "server_assignment2"
}
```

