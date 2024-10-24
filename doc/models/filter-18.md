
# Filter 18

## Structure

`Filter18`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Identifier` | `string` | Optional | `filter[identifier]=value` List only those images matching this identifier. May return multiple results. |
| `Search` | `string` | Optional | `filter[search]=value` search for a value associated with a field on the given Image(s). |
| `State` | `string` | Optional | `filter[state]=value1,value2` state filtering will allow you to filter by the Image's current state. |
| `SourceType` | `string` | Optional | `filter[source_type]=value` filter images by the Image source's type.  Can be: `direct` or `stack_build` |
| `SourceId` | `string` | Optional | `filter[source_id]=ID` Image filtering by source ID.  Submit the ID of the Image source you wish to filter for and the return will be any Images created from that source. |

## Example (as JSON)

```json
{
  "identifier": "identifier4",
  "search": "search4",
  "state": "state2",
  "source_type": "source_type6",
  "source_id": "source_id0"
}
```

