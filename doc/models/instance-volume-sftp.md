
# Instance Volume SFTP

Information about connecting to a instance volume over SFTP.

## Structure

`InstanceVolumeSFTP`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Host` | `string` | Required | The hostname for connecting to the volume over SFTP. |
| `Port` | `double` | Required | The port number to use when connecting. |
| `Username` | `string` | Required | The username to use when connecting. |
| `Password` | [`Password1`](../../doc/models/password-1.md) | Required | Password configuration settings for the remote access of the container volume. |

## Example (as JSON)

```json
{
  "host": "host0",
  "port": 231.78,
  "username": "username8",
  "password": {
    "algorithm": "sha512",
    "data": "data4"
  }
}
```

