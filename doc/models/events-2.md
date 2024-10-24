
# Events 2

Container events that can be configured to report to a webhook.

## Structure

`Events2`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Deploy` | `string` | Optional | A webhook to hit when a container deploy event happens. |
| `Start` | `string` | Optional | A webhook to hit when a container start event happens. |
| `Stop` | `string` | Optional | A webhook to hit when a container stop event happens. |

## Example (as JSON)

```json
{
  "deploy": "deploy6",
  "start": "start0",
  "stop": "stop8"
}
```

