
# Environment 2

Environment resource resources.

## Structure

`Environment2`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Id` | `string` | Required | A 24 character hex string used to identify a unique resource. |
| `Manage` | `bool` | Required | A boolean where true represents this environment can be managed by the resource (i.e. its not just read-only). |

## Example (as JSON)

```json
{
  "id": "651586fca6078e98982dbd90",
  "manage": false
}
```

