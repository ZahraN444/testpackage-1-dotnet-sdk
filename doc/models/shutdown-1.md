
# Shutdown 1

Configuration for what to do during container shutdown.

## Structure

`Shutdown1`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `GracefulTimeout` | [`Shutdown1GracefulTimeout`](../../doc/models/containers/shutdown-1-graceful-timeout.md) | Optional | This is a container for any-of cases. |
| `Signals` | [`List<SignalEnum>`](../../doc/models/signal-enum.md) | Optional | Process signal sent to the container process. |

## Example (as JSON)

```json
{
  "graceful_timeout": "String1",
  "signals": [
    "SIGHUP",
    "SIGQUIT"
  ]
}
```

