
# Membership Events

A collection of timestamps for each event in the membership's lifetime.

## Structure

`MembershipEvents`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Created` | `DateTime?` | Optional | The timestamp of when the membership was created. |
| `Updated` | `DateTime?` | Optional | The timestamp of when the membership was updated. |
| `Deleted` | `DateTime?` | Optional | The timestamp of when the membership was deleted. |
| `Joined` | `DateTime` | Required | The timestamp of when the membership was accepted. |

## Example (as JSON)

```json
{
  "created": "01/30/2021 08:30:00",
  "updated": "01/30/2021 08:30:00",
  "deleted": "01/30/2021 08:30:00",
  "joined": "01/30/2021 08:30:00"
}
```

