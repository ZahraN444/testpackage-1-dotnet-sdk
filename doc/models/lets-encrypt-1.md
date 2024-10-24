
# Lets Encrypt 1

Configuration settings to embed a TLS certificate in the container.

## Structure

`LetsEncrypt1`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Enable` | `bool` | Required | A boolean where true represents the desire for a container to have its corresponding TLS certificate(s) injected into the configured path(s). |
| `CertificatePath` | `string` | Optional | Path where the `certificate.cert` will be saved. |
| `ChainPath` | `string` | Optional | Path where the `certificate.chain` will be saved. |
| `KeyPath` | `string` | Optional | Path where the `certificate.key` will be saved. |
| `BundlePath` | `string` | Optional | Path where the `certificate.bundle` will be saved. |
| `AdditionalCertsPath` | `string` | Optional | File path where any remaining certificate files will be stored. |

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

