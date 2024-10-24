
# Filter 22

## Structure

`Filter22`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Search` | `string` | Optional | `filter[search]=value` search for a value associated with a field on the given auto-scale group(s). |
| `Cluster` | `string` | Optional | `filter[cluster]=value` return a list of auto-scale groups that are associated with the specified cluster. |
| `Identifier` | `string` | Optional | `filter[identifier]=value` list only those auto-scale groups matching this identifier. May return multiple results. |
| `State` | `string` | Optional | `filter[state]=value1,value2` state filtering will allow you to filter by the provider's current state. |

## Example (as JSON)

```json
{
  "search": "search6",
  "cluster": "cluster8",
  "identifier": "identifier6",
  "state": "state2"
}
```

