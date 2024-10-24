
# Payment Result

A billing payment result.

## Structure

`PaymentResult`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Success` | `bool` | Required | A boolean where true represents the success of the payment. |
| `Error` | `string` | Required | A description of the error that took place. |

## Example (as JSON)

```json
{
  "success": false,
  "error": "error2"
}
```

