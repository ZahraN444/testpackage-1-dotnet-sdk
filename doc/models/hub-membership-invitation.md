
# Hub Membership Invitation

Information about a hub membership invitation.

## Structure

`HubMembershipInvitation`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Sender` | [`Sender`](../../doc/models/sender.md) | Required | Information about the origin account of the invitation. |
| `Recipient` | `string` | Required | The email address for the invitations recipient. |
| `Events` | [`InvitationEvents`](../../doc/models/invitation-events.md) | Required | A collection of timestamps for each event in the invitation's lifetime. |

## Example (as JSON)

```json
{
  "sender": {
    "id": "651586fca6078e98982dbd90",
    "type": "type2"
  },
  "recipient": "recipient2",
  "events": {
    "created": "01/30/2021 08:30:00",
    "updated": "01/30/2021 08:30:00",
    "deleted": "01/30/2021 08:30:00",
    "accepted": "01/30/2021 08:30:00",
    "declined": "01/30/2021 08:30:00",
    "revoked": "01/30/2021 08:30:00"
  }
}
```

