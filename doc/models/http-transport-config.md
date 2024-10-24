
# Http Transport Config

Additional configuration options for the HTTP transport mode.

## Structure

`HttpTransportConfig`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Type` | `string` | Required, Constant | **Default**: `"http"` |
| `Details` | [`Details2`](../../doc/models/details-2.md) | Required | - |

## Example (as JSON)

```json
{
  "type": "http",
  "details": {
    "connections": {
      "max_idle_conns_per_connection": 152
    },
    "telemetry": {
      "disable_url_tracking": false,
      "disable_router_metrics": false,
      "max_trackable_urls": 202,
      "tracking_window": "String7",
      "track_invalid_requests": false,
      "group_paths": {
        "key0": "group_paths8"
      },
      "ignore_paths": [
        "ignore_paths0"
      ]
    }
  }
}
```

