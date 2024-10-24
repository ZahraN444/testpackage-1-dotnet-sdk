
# V1 Infrastructure Servers Request 1

## Structure

`V1InfrastructureServersRequest1`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Constraints` | [`Constraints2`](../../doc/models/constraints-2.md) | Required | Server constriants. |

## Example (as JSON)

```json
{
  "constraints": {
    "tags": [
      "tags3",
      "tags4",
      "tags5"
    ],
    "allow": {
      "pool": false,
      "services": false,
      "overcommit": false
    }
  }
}
```

