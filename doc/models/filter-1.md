
# Filter 1

## Structure

`Filter1`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Search` | `string` | Optional | `filter[search]=value` search for the specified text on supported fields. |
| `State` | `string` | Optional | `filter[state]=value1,value2` state filtering will allow you to filter by the invoice's current state. |
| `RangeStart` | `DateTime?` | Optional | The start date from when to pull the invoices |
| `RangeEnd` | `DateTime?` | Optional | The end date from when to pull the invoices |

## Example (as JSON)

```json
{
  "range-start": "01/30/2021 08:30:00",
  "range-end": "01/30/2021 08:30:00",
  "search": "search2",
  "state": "state4"
}
```

