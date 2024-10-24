
# V1 Account 2 Fa Setup Response 1

## Structure

`V1Account2faSetupResponse1`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Data` | [`TwoFactorAuthRecovery`](../../doc/models/two-factor-auth-recovery.md) | Required | - |

## Example (as JSON)

```json
{
  "data": {
    "recovery_codes": [
      "recovery_codes1",
      "recovery_codes0"
    ],
    "totp_passcode": "totp_passcode2"
  }
}
```

