
# Server Provider

A resource regarding the provider a given server is deployed from.

## Structure

`ServerProvider`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Vendor` | `string` | Required | The vendor for the provider this server is deployed from. |
| `Model` | `string` | Required | The model of the server that is deployed. |
| `Location` | `string` | Required | A location where the server is deployed. |
| `Server` | `string` | Required | A provider specific identifier for the server. |
| `InitIps` | `List<string>` | Optional | The IP's assigned to this server during provisioning. |
| `MacAddr` | `string` | Optional | The mac address for the server. |
| `Extra` | `object` | Optional | - |
| `ProvisionOptions` | [`ProvisionOptions`](../../doc/models/provision-options.md) | Optional | - |

## Example (as JSON)

```json
{
  "vendor": "vendor6",
  "model": "model8",
  "location": "location4",
  "server": "server4",
  "init_ips": [
    "init_ips1",
    "init_ips0"
  ],
  "mac_addr": "mac_addr4",
  "extra": {
    "key1": "val1",
    "key2": "val2"
  },
  "provision_options": {
    "attachesd_storage_size": 103.2,
    "reservation_id": "reservation_id8"
  }
}
```

