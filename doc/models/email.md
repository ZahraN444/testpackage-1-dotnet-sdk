
# Email

Information about the email address associated with the Account.

## Structure

`Email`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Address` | `string` | Required | The email address. |
| `Verified` | `bool` | Required | If true, the email has been verified and the Account is active. |
| `Added` | `DateTime` | Required | The date the email was added to the Account |

## Example (as JSON)

```json
{
  "address": "address0",
  "verified": false,
  "added": "01/30/2021 08:30:00"
}
```

