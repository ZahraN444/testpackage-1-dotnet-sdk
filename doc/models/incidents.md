
# Incidents

## Structure

`Incidents`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Info` | [`SecuritySnapshotIncidentBreakdown`](../../doc/models/security-snapshot-incident-breakdown.md) | Optional | A breakdown of a snapshot's incidents inside a security report. |
| `Low` | [`SecuritySnapshotIncidentBreakdown`](../../doc/models/security-snapshot-incident-breakdown.md) | Optional | A breakdown of a snapshot's incidents inside a security report. |
| `Medium` | [`SecuritySnapshotIncidentBreakdown`](../../doc/models/security-snapshot-incident-breakdown.md) | Optional | A breakdown of a snapshot's incidents inside a security report. |
| `High` | [`SecuritySnapshotIncidentBreakdown`](../../doc/models/security-snapshot-incident-breakdown.md) | Optional | A breakdown of a snapshot's incidents inside a security report. |
| `Critical` | [`SecuritySnapshotIncidentBreakdown`](../../doc/models/security-snapshot-incident-breakdown.md) | Optional | A breakdown of a snapshot's incidents inside a security report. |

## Example (as JSON)

```json
{
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
}
```

