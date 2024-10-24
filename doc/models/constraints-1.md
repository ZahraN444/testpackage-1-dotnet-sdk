
# Constraints 1

Settings that give more granular control over deployment targets and conditions.

## Structure

`Constraints1`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Node` | [`Node1`](../../doc/models/node-1.md) | Optional | Constraint settings related to which nodes an instance can be deployed to. |
| `Secrets` | `List<string>` | Optional | - |

## Example (as JSON)

```json
{
  "node": {
    "tags": {
      "any": [
        "any6",
        "any7"
      ],
      "all": [
        "all9"
      ]
    }
  },
  "secrets": [
    "secrets3"
  ]
}
```

