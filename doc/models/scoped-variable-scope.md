
# Scoped Variable Scope

Information about the assignment of the scoped variable and how it is invoked.

## Structure

`ScopedVariableScope`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Containers` | [`Containers1`](../../doc/models/containers-1.md) | Required | Information about the assignment of the scoped variable to different containers in the environment. |

## Example (as JSON)

```json
{
  "containers": {
    "global": false,
    "ids": [
      "ids3",
      "ids4",
      "ids5"
    ],
    "identifiers": [
      "identifiers8",
      "identifiers9"
    ]
  }
}
```

