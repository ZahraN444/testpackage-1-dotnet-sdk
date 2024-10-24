
# V1 Hubs Current Integrations Request 1

## Structure

`V1HubsCurrentIntegrationsRequest1`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Name` | `string` | Optional | A name for the Integration. |
| `Vendor` | `string` | Required | Unique vendor for the Integration, subject to validation. |
| `Identifier` | `string` | Optional | A human-readable identifier used to refer to a resource, where using the official ID may be inconvenient.<br>The identifier is automatically tokenized from the name/relevant field of the resource if one is not provided. For example, a container named "My Container" will<br>have the identifier of `my-container` and is automatically created by the platform.<br><br>The identifier does not have to be unique. |
| `Auth` | [`Auth6`](../../doc/models/auth-6.md) | Optional | Authentication information for the Integration. |
| `Extra` | `Dictionary<string, string>` | Optional | Additional key-value pairs associated with the Integration. |

## Example (as JSON)

```json
{
  "name": "name0",
  "vendor": "vendor6",
  "identifier": "identifier2",
  "auth": {
    "region": "region2",
    "namespace": "namespace6",
    "api_key": "api_key6",
    "key_id": "key_id2",
    "secret": "secret2"
  },
  "extra": {
    "key0": "extra8",
    "key1": "extra9",
    "key2": "extra0"
  }
}
```

