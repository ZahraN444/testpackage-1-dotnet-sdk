
# Constraints

## Structure

`Constraints`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Node` | [`Node`](../../doc/models/node.md) | Optional | - |
| `Secrets` | `List<string>` | Optional | - |
| `Containers` | `List<string>` | Optional | - |

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
    "secrets9"
  ],
  "containers": [
    "containers5",
    "containers4"
  ]
}
```

