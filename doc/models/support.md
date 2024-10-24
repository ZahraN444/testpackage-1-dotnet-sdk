
# Support

Information about the support component of the billing item.

## Structure

`Support`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Id` | `string` | Required | A 24 character hex string used to identify a unique resource. |
| `Name` | `string` | Required | The support contract name. |
| `Price` | `int` | Required | The price of the support contract (monthly). |

## Example (as JSON)

```json
{
  "id": "651586fca6078e98982dbd90",
  "name": "name6",
  "price": 166
}
```

