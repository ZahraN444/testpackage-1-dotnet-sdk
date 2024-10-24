
# V1 Sdn Networks Request

## Structure

`V1SdnNetworksRequest`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Name` | `string` | Required | The name of the Network. |
| `Identifier` | `string` | Required | A Network identifier used to construct http calls that specifically use this Network over another. |
| `Cluster` | `string` | Required | The infrastructure Cluster the Environments belonging to this Network belong to. |
| `Environments` | `List<string>` | Required | An array of Environment Ids |

## Example (as JSON)

```json
{
  "name": "name2",
  "identifier": "identifier0",
  "cluster": "cluster2",
  "environments": [
    "environments5",
    "environments6"
  ]
}
```

