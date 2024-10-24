
# V1 Security Report Response

## Structure

`V1SecurityReportResponse`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Data` | [`SecurityReport`](../../doc/models/security-report.md) | Required | A report of all security events captured by the platform over a range of time. |

## Example (as JSON)

```json
{
  "data": {
    "hub_id": "651586fca6078e98982dbd90",
    "created": "01/30/2021 08:30:00",
    "range": {
      "start": "01/30/2021 08:30:00",
      "end": "01/30/2021 08:30:00"
    },
    "summary": {
      "incidents": [
        {
          "risk": "low",
          "surface": "fs",
          "event": "suggestion",
          "attack": "none",
          "count": 44
        }
      ]
    },
    "snapshots": [
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
        "count": 106
      }
    ]
  }
}
```

