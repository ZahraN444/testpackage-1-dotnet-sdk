
# Allow 1

Server constraints for the given Server.

## Structure

`Allow1`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Pool` | `bool` | Required | A boolean where true represents the Server can accept containers with no tags set. |
| `Services` | `bool` | Required | A boolean where true represents the Server being a target for service containers. |
| `Overcommit` | `bool` | Required | A boolean where true represents the desire for the Server to allow the overcommitting of shares. |

## Example (as JSON)

```json
{
  "pool": false,
  "services": false,
  "overcommit": false
}
```

