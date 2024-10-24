
# Annoucement Update

An update to an Announcement.

## Structure

`AnnoucementUpdate`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Id` | `string` | Required | A 24 character hex string used to identify a unique resource. |
| `Message` | `string` | Required | The text describing the update to the announcement. |
| `Creator` | [`CreatorScope`](../../doc/models/creator-scope.md) | Required | The creator scope is embedded in resource objects to describe who created them |
| `Time` | `DateTime` | Required | A timestamp of when the update took place. |

## Example (as JSON)

```json
{
  "id": "651586fca6078e98982dbd90",
  "message": "message6",
  "creator": {
    "id": "651586fca6078e98982dbd90",
    "type": "employee"
  },
  "time": "01/30/2021 08:30:00"
}
```

