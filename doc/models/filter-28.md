
# Filter 28

## Structure

`Filter28`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Identifier` | `string` | Optional | `filter[identifier]=value` List only those stacks matching this identifier. May return multiple results. |
| `Search` | `string` | Optional | `filter[search]=value` search for a value associated with a field on the given Stack(s). |
| `State` | `string` | Optional | `filter[state]=value1,value2` state filtering will allow you to filter by the Stack's current state. |

## Example (as JSON)

```json
{
  "identifier": "identifier8",
  "search": "search2",
  "state": "state0"
}
```

