
# Allow

Settings for the server, things that are or are not allowed.

## Structure

`Allow`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Pool` | `bool` | Required | A boolean where true means - allow containers with no tags specified to be deployed to this server. |
| `Services` | `bool` | Required | A boolean where true means - allow service containers to be deployed to this container. |
| `Overcommit` | `bool` | Required | A boolean where true means - allow twice the normal amount of CPU shares to be allocated to containers deployed to this server. |

## Example (as JSON)

```json
{
  "pool": false,
  "services": false,
  "overcommit": false
}
```

