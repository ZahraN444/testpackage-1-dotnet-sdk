
# Invitation Events

A collection of timestamps for each event in the invitation's lifetime.

## Structure

`InvitationEvents`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Created` | `DateTime` | Required | The timestamp of when the invitation was created. |
| `Updated` | `DateTime` | Required | The timestamp of when the invitation was updated. |
| `Deleted` | `DateTime` | Required | The timestamp of when the invitation was deleted. |
| `Accepted` | `DateTime` | Required | The timestamp of when the invitation was accepted. |
| `Declined` | `DateTime` | Required | The timestamp of when the invitation was declined. |
| `Revoked` | `DateTime` | Required | The timestamp of when the invitation was revoked. |

## Example (as JSON)

```json
{
  "created": "01/30/2021 08:30:00",
  "updated": "01/30/2021 08:30:00",
  "deleted": "01/30/2021 08:30:00",
  "accepted": "01/30/2021 08:30:00",
  "declined": "01/30/2021 08:30:00",
  "revoked": "01/30/2021 08:30:00"
}
```

