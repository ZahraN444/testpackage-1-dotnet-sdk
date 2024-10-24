
# Late Fee

A late fee, applied to an invoice.

## Structure

`LateFee`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Id` | `string` | Required | A 24 character hex string used to identify a unique resource. |
| `Time` | `DateTime` | Required | A timestamp of when the late fee was created. |
| `Description` | `string` | Required | A description of the late fee. |
| `Amount` | `int` | Required | 1/10th of a cent. |

## Example (as JSON)

```json
{
  "id": "651586fca6078e98982dbd90",
  "time": "01/30/2021 08:30:00",
  "description": "description8",
  "amount": 226
}
```

