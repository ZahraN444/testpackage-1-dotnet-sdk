
# Server Features

A set of features a given server can have and their information.

## Structure

`ServerFeatures`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Sftp` | `bool` | Required | A boolean where true means the server accepts incoming SFTP connections through the remote volume integration. |
| `BaseVolumeGb` | `int?` | Optional | The size of the base volume (where Cycle stores container images on this server). |

## Example (as JSON)

```json
{
  "sftp": false,
  "base_volume_gb": 38
}
```

