
# SSH Source Credentials

## Structure

`SSHSourceCredentials`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Type` | `string` | Required, Constant | **Default**: `"ssh"` |
| `Credentials` | [`Credentials1`](../../doc/models/credentials-1.md) | Required | Authentication credentials for the Dockerfile image source type when authenticating with SSH. |

## Example (as JSON)

```json
{
  "type": "ssh",
  "credentials": {
    "username": "username4",
    "passphrase": "passphrase4",
    "private_key": "private_key0"
  }
}
```

