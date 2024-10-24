
# Filter 27

## Structure

`Filter27`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `RangeStart` | `DateTime?` | Optional | The start date from when to fetch Jobs |
| `RangeEnd` | `DateTime?` | Optional | The end date from when to fetch Jobs |
| `Search` | `string` | Optional | `filter[search]=value` search jobs for a value associated with a field on the given job(s). |
| `State` | `string` | Optional | `filter[state]=value1,value2` state filtering will allow you to filter by the job's current state. |

## Example (as JSON)

```json
{
  "range-start": "01/30/2021 08:30:00",
  "range-end": "01/30/2021 08:30:00",
  "search": "search8",
  "state": "state0"
}
```

