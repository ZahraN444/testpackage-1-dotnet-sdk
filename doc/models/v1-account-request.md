
# V1 Account Request

## Structure

`V1AccountRequest`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Name` | [`Name1`](../../doc/models/name-1.md) | Optional | The new name on the Account. |
| `AllowSupportLogin` | `bool?` | Optional | If true, Cycle employees will have the ability, upon consent, to access the account for support purposes. This access will be logged. |

## Example (as JSON)

```json
{
  "name": {
    "first": "first6",
    "last": "last0"
  },
  "allow_support_login": false
}
```

