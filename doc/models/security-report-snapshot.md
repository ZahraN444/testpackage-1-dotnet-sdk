
# Security Report Snapshot

A snapshot of security events for the given interval.

## Structure

`SecurityReportSnapshot`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Time` | `DateTime` | Required | - |
| `Incidents` | [`Incidents`](../../doc/models/incidents.md) | Required | - |
| `Count` | `int` | Required | - |

## Example (as JSON)

```json
{
  "time": "01/30/2021 08:30:00",
  "incidents": {
    "info": {
      "surface": {
        "network": 56,
        "service": 6,
        "fs": 30,
        "api": 186
      },
      "attack": {
        "none": 94,
        "auth-failure": 232,
        "brute-force": 210,
        "exploit-vulnerability": 106,
        "social-engineer": 248
      }
    },
    "low": {
      "surface": {
        "network": 56,
        "service": 6,
        "fs": 30,
        "api": 186
      },
      "attack": {
        "none": 94,
        "auth-failure": 232,
        "brute-force": 210,
        "exploit-vulnerability": 106,
        "social-engineer": 248
      }
    },
    "medium": {
      "surface": {
        "network": 56,
        "service": 6,
        "fs": 30,
        "api": 186
      },
      "attack": {
        "none": 94,
        "auth-failure": 232,
        "brute-force": 210,
        "exploit-vulnerability": 106,
        "social-engineer": 248
      }
    },
    "high": {
      "surface": {
        "network": 56,
        "service": 6,
        "fs": 30,
        "api": 186
      },
      "attack": {
        "none": 94,
        "auth-failure": 232,
        "brute-force": 210,
        "exploit-vulnerability": 106,
        "social-engineer": 248
      }
    },
    "critical": {
      "surface": {
        "network": 56,
        "service": 6,
        "fs": 30,
        "api": 186
      },
      "attack": {
        "none": 94,
        "auth-failure": 232,
        "brute-force": 210,
        "exploit-vulnerability": 106,
        "social-engineer": 248
      }
    }
  },
  "count": 244
}
```

