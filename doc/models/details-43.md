
# Details 43

## Structure

`Details43`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Name` | `string` | Required | - |
| `About` | [`Details43About`](../../doc/models/containers/details-43-about.md) | Optional | This is a container for any-of cases. |
| `Cluster` | `string` | Required | - |
| `Features` | [`Features`](../../doc/models/features.md) | Required | An object representing specialized features configured for this environment. |

## Example (as JSON)

```json
{
  "name": "name2",
  "about": {
    "description": "description4",
    "favorite": false
  },
  "cluster": "cluster2",
  "features": {
    "legacy_networking": false
  }
}
```

