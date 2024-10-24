
# Webhooks 1

Webhooks that can be set for specific event reporting and advanced container configurations.

## Structure

`Webhooks1`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Events` | [`Events2`](../../doc/models/events-2.md) | Optional | Container events that can be configured to report to a webhook. |
| `Config` | `string` | Optional | An endpoint that the platform will react out to with a get request.  This endpoint serves a partial container config which can modify `runtime`, `resources`, and `integrations` configurations. |

## Example (as JSON)

```json
{
  "events": {
    "deploy": "deploy2",
    "start": "start4",
    "stop": "stop2"
  },
  "config": "config6"
}
```

