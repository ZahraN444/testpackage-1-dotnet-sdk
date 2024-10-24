
# Shutdown

## Structure

`Shutdown`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `GracefulTimeout` | [`ShutdownGracefulTimeout`](../../doc/models/containers/shutdown-graceful-timeout.md) | Optional | This is a container for any-of cases. |
| `Signals` | `List<string>` | Optional | - |

## Example (as JSON)

```json
{
  "graceful_timeout": "String5",
  "signals": [
    "signals0",
    "signals1"
  ]
}
```

