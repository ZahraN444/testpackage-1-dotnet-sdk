
# Config

## Structure

`Config`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `StickySessions` | `bool` | Required | If a request comes in from the same origin, ensure it hits the same destination. |
| `DestinationRetries` | `int` | Required | If a destination is unavailable, retry up to [x] times, instead of immediately failing with a 503/504 error. |
| `Tls` | [`Tls`](../../doc/models/tls.md) | Optional | TLS termination configuration. If null, the platform will use the default configuration. Port 443 by default has TLS termination enabled. |
| `Timeouts` | [`Timeouts2`](../../doc/models/timeouts-2.md) | Required | Defines how the length of various sorts of timeouts when communicating with the destination. |
| `Extension` | [`ConfigExtension`](../../doc/models/containers/config-extension.md) | Optional | This is a container for one-of cases. |

## Example (as JSON)

```json
{
  "sticky_sessions": false,
  "destination_retries": 86,
  "timeouts": {
    "destination_connection": "72h45m2s"
  },
  "tls": {
    "server_name": "server_name2",
    "allow_insecure": false,
    "client_cert_auth": "client_cert_auth6",
    "client_auth": "require"
  },
  "extension": {
    "type": "type6",
    "details": {
      "key0": {
        "key1": "val1",
        "key2": "val2"
      },
      "key1": {
        "key1": "val1",
        "key2": "val2"
      },
      "key2": {
        "key1": "val1",
        "key2": "val2"
      }
    }
  }
}
```

