
# Remote Access 1

Configuration settings for remotely accessing the container volume.

## Structure

`RemoteAccess1`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Enable` | `bool` | Required | A boolean where true represents this container volume being open to remote access connections over SFTP. |
| `Ips` | `List<string>` | Optional | - |
| `WebHook` | `string` | Optional | Call out to a webhook to authenticate usernames/passwords if an organization manages their own accounts |
| `Password` | [`Password1`](../../doc/models/password-1.md) | Required | Password configuration settings for the remote access of the container volume. |

## Example (as JSON)

```json
{
  "enable": false,
  "ips": [
    "ips2",
    "ips3"
  ],
  "web_hook": "web_hook8",
  "password": {
    "algorithm": "sha512",
    "data": "data4"
  }
}
```

