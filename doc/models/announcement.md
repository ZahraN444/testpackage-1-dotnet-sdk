
# Announcement

An announcement from the Cycle team.

## Structure

`Announcement`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Id` | `string` | Required | A 24 character hex string used to identify a unique resource. |
| `Title` | `string` | Required | A description of the event being announced. |
| `Description` | `string` | Required | A description of the announcement |
| `Updates` | [`List<AnnoucementUpdate>`](../../doc/models/annoucement-update.md) | Required | - |
| `AffectedIntegrations` | `List<string>` | Optional | - |
| `Creator` | [`CreatorScope`](../../doc/models/creator-scope.md) | Required | The creator scope is embedded in resource objects to describe who created them |
| `State` | [`State2`](../../doc/models/state-2.md) | Required | - |
| `Priority` | [`PriorityEnum`](../../doc/models/priority-enum.md) | Required | The priority or severity of the announcement. |
| `Events` | [`AnnouncementEvents`](../../doc/models/announcement-events.md) | Required | A collection of timestamps for each event in the announcement's lifetime. |

## Example (as JSON)

```json
{
  "id": "651586fca6078e98982dbd90",
  "title": "title0",
  "description": "description4",
  "updates": [
    {
      "id": "651586fca6078e98982dbd90",
      "message": "message0",
      "creator": {
        "id": "651586fca6078e98982dbd90",
        "type": "employee"
      },
      "time": "01/30/2021 08:30:00"
    }
  ],
  "creator": {
    "id": "651586fca6078e98982dbd90",
    "type": "employee"
  },
  "state": {
    "current": "deleted",
    "changed": "01/30/2021 08:30:00",
    "error": {
      "message": "message4",
      "time": "2016-03-13T12:52:32.123Z"
    }
  },
  "priority": "low",
  "events": {
    "created": "01/30/2021 08:30:00",
    "updated": "01/30/2021 08:30:00",
    "deleted": "01/30/2021 08:30:00",
    "resolved": "01/30/2021 08:30:00"
  },
  "affected_integrations": [
    "affected_integrations9"
  ]
}
```

