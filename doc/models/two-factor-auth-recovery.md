
# Two Factor Auth Recovery

## Structure

`TwoFactorAuthRecovery`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `RecoveryCodes` | `List<string>` | Required | - |
| `TotpPasscode` | `string` | Required | - |

## Example (as JSON)

```json
{
  "recovery_codes": [
    "recovery_codes3",
    "recovery_codes2"
  ],
  "totp_passcode": "totp_passcode2"
}
```

