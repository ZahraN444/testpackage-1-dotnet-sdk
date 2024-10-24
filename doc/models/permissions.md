
# Permissions

Permissions information for an API Key

## Structure

`Permissions`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `AllEnvironments` | `bool` | Required | A boolean, where true represents this API key is authorized to make requests that involve all of a hubs environments |
| `Environments` | [`List<EnvironmentPermission>`](../../doc/models/environment-permission.md) | Required | An environment ID and a boolean representing management configuration for an API key |

## Example (as JSON)

```json
{
  "all_environments": false,
  "environments": [
    {
      "id": "651586fca6078e98982dbd90",
      "manage": false
    }
  ]
}
```

