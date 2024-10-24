
# V1 Account Invites Request

## Structure

`V1AccountInvitesRequest`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Accept` | `bool?` | Optional | If true, the Invite will be accepted and the associated Account will join the Hub. |
| `Decline` | `bool?` | Optional | If true, the Invite will be declined and the associated Account will NOT join the Hub. |

## Example (as JSON)

```json
{
  "accept": false,
  "decline": false
}
```

