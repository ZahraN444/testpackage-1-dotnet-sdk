
# Permissions 2

The Environment permissions the invitee will have

## Structure

`Permissions2`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `AllEnvironments` | `bool` | Required | Boolean value that indicates the user has access to all Environments |
| `Environments` | [`List<Environment1>`](../../doc/models/environment-1.md) | Required | A list of objects that describe the specific environments the invitee will have access to |

## Example (as JSON)

```json
{
  "all_environments": false,
  "environments": [
    {
      "id": "id2",
      "manage": false
    }
  ]
}
```

