
# Filter 23

## Structure

`Filter23`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `State` | `string` | Optional | `filter[state]=value1,value2` state filtering will allow you to filter by the provider's current state. |
| `Tags` | `string` | Optional | `filter[tags]=tagone,tagtwo,tagthree` filtering by Server tag.  Enter one or more tags (comma separated) and the return will include servers that match any tags in the list. |
| `Clusters` | `string` | Optional | `filter[clusters]=clusterone,clustertwo` filtering by cluster.  Enter one or more clusters (commas separated) and the return will include servers that match any clusters in the list. |
| `Providers` | `string` | Optional | `filter[providers]=providerone,providertwo` filtering by provider.  Enter one or more providers (commas separated) and the return will include servers that match any providers in the list. |

## Example (as JSON)

```json
{
  "state": "state2",
  "tags": "tags2",
  "clusters": "clusters8",
  "providers": "providers8"
}
```

