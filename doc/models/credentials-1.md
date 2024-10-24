
# Credentials 1

Authentication credentials for the Dockerfile image source type when authenticating with SSH.

## Structure

`Credentials1`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Username` | `string` | Required | The username for the repo service, that is used to authenticate an ssh key. |
| `Passphrase` | `string` | Required | The passphrase used for the key. |
| `PrivateKey` | `string` | Required | A pem encoded private key. |

## Example (as JSON)

```json
{
  "username": "username2",
  "passphrase": "passphrase2",
  "private_key": "private_key2"
}
```

