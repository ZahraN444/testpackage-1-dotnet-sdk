
# V1 Environments Services Discovery Tasks Request

## Structure

`V1EnvironmentsServicesDiscoveryTasksRequest`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Action` | `string` | Required, Constant | The name of the action to perform.<br>**Default**: `"reconfigure"` |
| `Contents` | [`Contents9`](../../doc/models/contents-9.md) | Required | - |

## Example (as JSON)

```json
{
  "action": "reconfigure",
  "contents": {
    "config": {
      "hosts": {
        "key0": {
          "ipv4": [
            "ipv42",
            "ipv43"
          ],
          "ipv6": [
            "ipv66",
            "ipv67",
            "ipv68"
          ]
        }
      }
    },
    "high_availability": false,
    "auto_update": false
  }
}
```

