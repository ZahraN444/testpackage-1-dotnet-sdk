
# Reconfigure Volume Task

## Structure

`ReconfigureVolumeTask`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Action` | `string` | Required, Constant | The action to take.<br>**Default**: `"volumes.reconfigure"` |
| `Contents` | [`List<VolumeSummary>`](../../doc/models/volume-summary.md) | Required | An array of volume objects to be reconfigured. |

## Example (as JSON)

```json
{
  "action": "volumes.reconfigure",
  "contents": [
    {
      "id": "651586fca6078e98982dbd90",
      "hash": "hash2",
      "config": {
        "read_only": false,
        "local": {
          "max_size": "max_size6",
          "storage_pool": false
        },
        "destination": "destination8",
        "remote_access": {
          "enable": false,
          "ips": [
            "ips4",
            "ips5",
            "ips6"
          ],
          "web_hook": "web_hook0",
          "password": {
            "algorithm": "sha512",
            "data": "data4"
          }
        }
      }
    }
  ]
}
```

