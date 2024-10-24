
# Filter 15

## Structure

`Filter15`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Identifier` | `string` | Optional | `filter[identifier]=value` List only those environments matching this identifier. May return multiple results. |
| `Search` | `string` | Optional | `filter[search]=value` search hubs for a value associated with a field on the given Hub(s). |
| `State` | `string` | Optional | `filter[state]=value1,value2` state filtering will allow you to filter by the Hub's current state. |

## Example (as JSON)

```json
{
  "identifier": "identifier0",
  "search": "search0",
  "state": "state8"
}
```

