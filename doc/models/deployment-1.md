
# Deployment 1

Information about the deployment this record points to.

## Structure

`Deployment1`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `EnvironmentId` | `string` | Required | The ID of the environment with the deployment tag mapping we want to reference. |
| `Match` | [`Match1`](../../doc/models/match-1.md) | Required | Describes which container and which tagged deployment this record should target. |

## Example (as JSON)

```json
{
  "environment_id": "651586fca6078e98982dbd90",
  "match": {
    "container": "container2",
    "tag": "String5"
  }
}
```

