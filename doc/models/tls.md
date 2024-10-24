
# Tls

TLS termination configuration. If null, the platform will use the default configuration. Port 443 by default has TLS termination enabled.

## Structure

`Tls`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `ServerName` | `string` | Optional | [Advanced] Change the domain the controller listens on. |
| `AllowInsecure` | `bool?` | Optional | If enabled, accept TLS traffic with an invalid certificate. This is usually done for development/testing, and is not recommended for production use. |
| `ClientCertAuth` | `string` | Optional | A PEM encoded string of certificates. |
| `ClientAuth` | [`ClientAuthEnum?`](../../doc/models/client-auth-enum.md) | Optional | Defines how to validate the connecting TLS certificate.<br>`none`: Do not require a TLS certificate to be sent<br>`request`: Asks the client to send a TLS certificate, but does not require nor validate it.<br>`require`: Requires a certificate be sent for the request to be valid, but does not validate the certificate.<br>`require-verify`: Requires both that the client send a certificate, and that the certificate is valid. This is required when using https. |

## Example (as JSON)

```json
{
  "server_name": "server_name6",
  "allow_insecure": false,
  "client_cert_auth": "client_cert_auth8",
  "client_auth": "require"
}
```

