
# Filter 7

## Structure

`Filter7`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Identifier` | `string` | Optional | `filter[identifier]=value` List only those environments matching this identifier. May return multiple results. |
| `Search` | `string` | Optional | `filter[search]=value` search for a value associated with a field on the given Scoped Variable(s). |
| `State` | `string` | Optional | `filter[state]=value1,value2` state filtering will allow you to filter by the Scoped Variable's current state. |

## Example (as JSON)

```json
{
  "identifier": "identifier8",
  "search": "search2",
  "state": "state0"
}
```

