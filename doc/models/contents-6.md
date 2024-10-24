
# Contents 6

Supplemental information needed to perform the action.

## Structure

`Contents6`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Sftp` | `bool` | Required | A boolean where true represents the desire for the server to accept incoming SFTP requests for container volumes. |
| `BaseVolumeGb` | `int?` | Required | A number in GB for how big the base volume should be.  This cannot be lower than the currently set value for the server. |

## Example (as JSON)

```json
{
  "sftp": false,
  "base_volume_gb": 90
}
```

