
# Filter 16

## Structure

`Filter16`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Search` | `string` | Optional | `filter[search]=value` search activities for a value associated with a field on the given activity(s). |
| `State` | `string` | Optional | `filter[state]=value1,value2` state filtering will allow you to filter by the activity's current state. |
| `User` | `string` | Optional | `filter[user]=ID` user filtering by ID. Submit the ID of the user you wish to filter for and the return will be any activity from that user. |
| `Environment` | `string` | Optional | `filter[environment]=ID` environment filtering by ID. Submit the ID of the environment you wish to filter for and the return will be any activity from that environment. |
| `Container` | `string` | Optional | `filter[container]=ID` container filtering by ID. Submit the ID of the container you wish to filter for and the return will be any activity from that container. |
| `Instance` | `string` | Optional | `filter[instance]=ID` instance filtering by ID. Submit the ID of the instance you wish to filter for and the return will be any activity from that instance. |
| `Server` | `string` | Optional | `filter[server]=ID` server filtering by ID. Submit the ID of the server you wish to filter for and the return will be any activity from that server. |
| `Events` | `string` | Optional | `filter[events]=value` filter by event names. Example: `filter[events]=environment.services.vpn.login` |
| `Verbosity` | `int?` | Optional | `filter[verbosity]=integer` filter the activity return by verbosity. The verbosity can be:<br>`0` - Activity that users would find useful.<br>`1` - Activity that can be useful when tracking down how something happened.<br>`2` - Full activity, can be useful in debugging problems. |

## Example (as JSON)

```json
{
  "search": "search6",
  "state": "state4",
  "user": "user8",
  "environment": "environment4",
  "container": "container0"
}
```

