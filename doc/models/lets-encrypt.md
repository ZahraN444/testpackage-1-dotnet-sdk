
# Lets Encrypt

## Structure

`LetsEncrypt`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Enable` | `bool` | Required | - |
| `CertificatePath` | `string` | Optional | - |
| `ChainPath` | `string` | Optional | - |
| `KeyPath` | `string` | Optional | - |
| `BundlePath` | `string` | Optional | - |
| `AdditionalCertsPath` | `string` | Optional | - |

## Example (as JSON)

```json
{
  "enable": false,
  "certificate_path": "certificate_path0",
  "chain_path": "chain_path8",
  "key_path": "key_path6",
  "bundle_path": "bundle_path2",
  "additional_certs_path": "additional_certs_path0"
}
```

