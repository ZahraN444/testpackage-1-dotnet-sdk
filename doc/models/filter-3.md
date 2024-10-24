
# Filter 3

## Structure

`Filter3`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Creator` | `string` | Optional | `filter[creator]=account-ID` filter for environments matching a particular creator, such as `account-ID`. |
| `Identifier` | `string` | Optional | `filter[identifier]=value` List only those environments matching this identifier. May return multiple results. |
| `Search` | `string` | Optional | `filter[search]=value` search for a value associated with a field on the given environment(s). |
| `State` | `string` | Optional | `filter[state]=value1,value2` state filtering will allow you to filter by the environment's current state. |
| `StackBuild` | `string` | Optional | `filter[stack_build]=ID` stack build filtering by ID.  Submit the ID of the stack build you wish to filter for and the return sill be any environments that have the stack build deployed to them. |

## Example (as JSON)

```json
{
  "creator": "creator6",
  "identifier": "identifier4",
  "search": "search6",
  "state": "state4",
  "stack_build": "stack_build2"
}
```

