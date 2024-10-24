
# Node 1

Constraint settings related to which nodes an instance can be deployed to.

## Structure

`Node1`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Tags` | [`Tags1`](../../doc/models/tags-1.md) | Required | Lists of server tags that formally declair servers that match the criteria for deployment. |

## Example (as JSON)

```json
{
  "tags": {
    "any": [
      "any6",
      "any7"
    ],
    "all": [
      "all9"
    ]
  }
}
```

