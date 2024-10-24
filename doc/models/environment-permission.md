
# Environment Permission

## Structure

`EnvironmentPermission`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Id` | `string` | Required | A 24 character hex string used to identify a unique resource. |
| `Manage` | `bool` | Required | A boolean, where true represents the API keys ability to make changes to the environment components |

## Example (as JSON)

```json
{
  "id": "651586fca6078e98982dbd90",
  "manage": false
}
```

