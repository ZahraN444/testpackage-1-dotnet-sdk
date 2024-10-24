
# Deployment Strategy

Information about supported container deployment strategies.

## Structure

`DeploymentStrategy`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Name` | `string` | Required | The human-friendly name of the deployment strategy. |
| `Disabled` | `bool` | Required | A boolean where true signifies a strategy is either not yet or no longer available. |
| `Description` | `string` | Required | A description for the deployment strategy. |

## Example (as JSON)

```json
{
  "name": "name6",
  "disabled": false,
  "description": "description6"
}
```

