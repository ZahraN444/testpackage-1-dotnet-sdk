
# Announcements List Response

## Structure

`AnnouncementsListResponse`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Data` | [`List<Announcement>`](../../doc/models/announcement.md) | Required | - |

## Example (as JSON)

```json
{
  "data": [
    {
      "id": "651586fca6078e98982dbd90",
      "title": "title6",
      "description": "description0",
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
      "priority": "notice",
      "events": {
        "created": "01/30/2021 08:30:00",
        "updated": "01/30/2021 08:30:00",
        "deleted": "01/30/2021 08:30:00",
        "resolved": "01/30/2021 08:30:00"
      },
      "affected_integrations": [
        "affected_integrations5"
      ]
    }
  ]
}
```

