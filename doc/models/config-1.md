
# Config 1

Defines how the transport for this controller operates.

## Structure

`Config1`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Performance` | `bool` | Required | Enable/disable performance mode. If enabled, some telemetry will be disabled to dedicate full processing to handling requests.<br>You will not see per-request breakdowns or URL logging if performance mode is enabled. |
| `Ingress` | [`Ingress`](../../doc/models/ingress.md) | Required | Defines how traffic gets into the load balancer. |
| `Timeouts` | [`Timeouts3`](../../doc/models/timeouts-3.md) | Required | Defines settings for various types of timeouts. |
| `Verbosity` | [`VerbosityEnum`](../../doc/models/verbosity-enum.md) | Required | Verbosity describes the level of logging detail for the controller |
| `Extension` | [`Config1Extension`](../../doc/models/containers/config-1-extension.md) | Optional | This is a container for one-of cases. |

## Example (as JSON)

```json
{
  "performance": false,
  "ingress": {
    "port": 242,
    "tls": {
      "enable": false
    }
  },
  "timeouts": {
    "idle": "72h45m2s"
  },
  "verbosity": "low",
  "extension": {
    "type": "type2",
    "details": {
      "connections": {
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
}
```

