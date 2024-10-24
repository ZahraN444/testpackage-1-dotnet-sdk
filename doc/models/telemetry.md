
# Telemetry

Configuration options for how telemetry is handled.

## Structure

`Telemetry`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `DisableUrlTracking` | `bool` | Required | Determines if the load balancer will track url metrics. Defaults to false. |
| `DisableRouterMetrics` | `bool` | Required | Determines if the load balancer will track router metrics. Defaults to false. |
| `MaxTrackableUrls` | `int?` | Optional | Determines how many URLs the load balancer will track at one time. Defaults to 150. |
| `TrackingWindow` | [`TelemetryTrackingWindow`](../../doc/models/containers/telemetry-tracking-window.md) | Optional | This is a container for any-of cases. |
| `TrackInvalidRequests` | `bool?` | Optional | Whether or not to track invalid requests. An invalid request is a request that came in that no router existed for. Usually this means bot requests. Defaults to false. |
| `GroupPaths` | `Dictionary<string, string>` | Optional | Group paths is used to group URLs.  The key is the URL and the value is the regex used to match URLs. |
| `IgnorePaths` | `List<string>` | Optional | An array of paths to exclude from tracking. |

## Example (as JSON)

```json
{
  "disable_url_tracking": false,
  "disable_router_metrics": false,
  "max_trackable_urls": 206,
  "tracking_window": "String3",
  "track_invalid_requests": false,
  "group_paths": {
    "key0": "group_paths6",
    "key1": "group_paths7"
  },
  "ignore_paths": [
    "ignore_paths0",
    "ignore_paths1"
  ]
}
```

