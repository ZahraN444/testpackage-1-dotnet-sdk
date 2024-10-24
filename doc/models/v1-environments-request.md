
# V1 Environments Request

## Structure

`V1EnvironmentsRequest`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Name` | `string` | Required | A user defined name for the Environment. |
| `Identifier` | `string` | Optional | A human-readable identifier used to refer to a resource, where using the official ID may be inconvenient.<br>The identifier is automatically tokenized from the name/relevant field of the resource if one is not provided. For example, a container named "My Container" will<br>have the identifier of `my-container` and is automatically created by the platform.<br><br>The identifier does not have to be unique. |
| `Cluster` | `string` | Required | The cluster this Environment is associated with. |
| `About` | [`About5`](../../doc/models/about-5.md) | Required | Contains details regarding the Environment. |
| `Features` | [`Features`](../../doc/models/features.md) | Required | An object representing specialized features configured for this environment. |

## Example (as JSON)

```json
{
  "name": "name6",
  "identifier": "identifier6",
  "cluster": "cluster2",
  "about": {
    "description": "description4"
  },
  "features": {
    "legacy_networking": false
  }
}
```

