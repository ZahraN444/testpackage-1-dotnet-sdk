
# Details 2

## Structure

`Details2`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Connections` | [`Connections`](../../doc/models/connections.md) | Required | Defines extra configuration options connections to the load balancer |
| `Telemetry` | [`Telemetry`](../../doc/models/telemetry.md) | Required | Configuration options for how telemetry is handled. |

## Example (as JSON)

```json
{
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
```

