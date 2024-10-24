
# V1 Containers Request 1

## Structure

`V1ContainersRequest1`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Name` | `string` | Optional | The name for the Container. |
| `Identifier` | `string` | Optional | The name for the identifier. |
| `Deprecate` | `bool?` | Optional | Sets whether Container should be deprecated. |
| `Lock` | `bool?` | Optional | When set to true, prevents this Container from being deleted. |
| `Annotation` | `Dictionary<string, string>` | Optional | User meta data for the Container. |

## Example (as JSON)

```json
{
  "name": "name0",
  "identifier": "identifier2",
  "deprecate": false,
  "lock": false,
  "annotation": {
    "key0": "annotation3"
  }
}
```

