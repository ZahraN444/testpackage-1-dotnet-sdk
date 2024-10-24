
# Tags 1

Lists of server tags that formally declair servers that match the criteria for deployment.

## Structure

`Tags1`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Any` | `List<string>` | Optional | A list of tags where a server matching any tags from the list is qualified as a deployment target. |
| `All` | `List<string>` | Optional | A list of tags where a server matching all tags from the list is the only scenario where the server is qualified as a deployment target. |

## Example (as JSON)

```json
{
  "any": [
    "any4"
  ],
  "all": [
    "all7",
    "all6"
  ]
}
```

