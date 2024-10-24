
# Account Email

Email information for an account

## Structure

`AccountEmail`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Address` | `string` | Required | The email address |
| `Verified` | `bool` | Required | A boolean representing if the email has been verified |
| `Added` | `DateTime` | Required | - |

## Example (as JSON)

```json
{
  "address": "address0",
  "verified": false,
  "added": "01/30/2021 08:30:00"
}
```

