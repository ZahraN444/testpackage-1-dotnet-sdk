
# Filter 9

## Structure

`Filter9`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `State` | `string` | Optional | `filter[state]=value1,value2` state filtering will allow you to filter by the instance's current state. |
| `Search` | `string` | Optional | `filter[search]=value` search instances for a value associated with a field on the given instance(s). |
| `Server` | `string` | Optional | `filter[server]=ID` server filtering by ID. Submit the ID of the server you wish to filter for and the return will be any instances of the container currently deployed to the given server. |
| `RangeStart` | `DateTime?` | Optional | The start date from when to pull the instances |
| `RangeEnd` | `DateTime?` | Optional | The end date from when to pull the instances |

## Example (as JSON)

```json
{
  "range-start": "01/30/2021 08:30:00",
  "range-end": "01/30/2021 08:30:00",
  "state": "state4",
  "search": "search2",
  "server": "server4"
}
```

