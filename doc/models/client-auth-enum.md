
# Client Auth Enum

Defines how to validate the connecting TLS certificate.
`none`: Do not require a TLS certificate to be sent
`request`: Asks the client to send a TLS certificate, but does not require nor validate it.
`require`: Requires a certificate be sent for the request to be valid, but does not validate the certificate.
`require-verify`: Requires both that the client send a certificate, and that the certificate is valid. This is required when using https.

## Enumeration

`ClientAuthEnum`

## Fields

| Name |
|  --- |
| `None` |
| `Request` |
| `Require` |
| `Requireverify` |

