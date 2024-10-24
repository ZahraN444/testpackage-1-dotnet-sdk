
# Filter 31

## Structure

`Filter31`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Identifier` | `string` | Optional | `filter[identifier]=value` List only those pipelines matching this identifier. May return multiple results. |
| `Search` | `string` | Optional | `filter[search]=value` search for a value associated with a field on the given pipelines(s). |
| `State` | `string` | Optional | `filter[state]=value1,value2` state filtering will allow you to filter by the Pipeline's current state. |

## Example (as JSON)

```json
{
  "identifier": "identifier8",
  "search": "search8",
  "state": "state0"
}
```

