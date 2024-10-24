
# Permissions 1

Information about this members permissions for a given resource.

## Structure

`Permissions1`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `AllEnvironments` | `bool` | Required | A boolean where true represents the member has access to view and manage all environments for the resource. |
| `Environments` | [`List<Environment2>`](../../doc/models/environment-2.md) | Required | An array of environments this resource has access to. |

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

