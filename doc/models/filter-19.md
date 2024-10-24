
# Filter 19

## Structure

`Filter19`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Identifier` | `string` | Optional | `filter[identifier]=value` List only those image sources matching this identifier. May return multiple results. |
| `Search` | `string` | Optional | `filter[search]=value` search for a value associated with a field on the given Image Source(s). |
| `State` | `string` | Optional | `filter[state]=value1,value2` state filtering will allow you to filter by the Image Source's current state. |

## Example (as JSON)

```json
{
  "identifier": "identifier0",
  "search": "search0",
  "state": "state8"
}
```

