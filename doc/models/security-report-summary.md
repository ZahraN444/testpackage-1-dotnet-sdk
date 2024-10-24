
# Security Report Summary

A summary of the incidents tags accumulated over the report's range.

## Structure

`SecurityReportSummary`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Incidents` | [`List<SecurityIncident>`](../../doc/models/security-incident.md) | Required | - |

## Example (as JSON)

```json
{
  "incidents": [
    {
      "risk": "low",
      "surface": "fs",
      "event": "suggestion",
      "attack": "none",
      "count": 44
    }
  ]
}
```

