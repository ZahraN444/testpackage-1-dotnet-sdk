
# V1 Account 2 Fa Recover Request

## Structure

`V1Account2faRecoverRequest`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Email` | `string` | Required | The user's email |
| `Password` | `string` | Required | - |
| `RecoveryCodes` | `List<string>` | Required | - |
| `Token` | `string` | Optional | - |

## Example (as JSON)

```json
{
  "email": "email4",
  "password": "password6",
  "recovery_codes": [
    "recovery_codes9",
    "recovery_codes8",
    "recovery_codes7"
  ],
  "token": "token6"
}
```

