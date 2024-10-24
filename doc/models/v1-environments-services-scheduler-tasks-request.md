
# V1 Environments Services Scheduler Tasks Request

## Structure

`V1EnvironmentsServicesSchedulerTasksRequest`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Action` | `string` | Required, Constant | The name of the action to perform.<br>**Default**: `"reconfigure"` |
| `Contents` | [`Contents10`](../../doc/models/contents-10.md) | Required | - |

## Example (as JSON)

```json
{
  "action": "reconfigure",
  "contents": {
    "config": {
      "public": false,
      "access_keys": [
        {
          "name": "name4",
          "secret": "secret0",
          "ips": [
            "ips8"
          ]
        }
      ]
    },
    "auto_update": false
  }
}
```

