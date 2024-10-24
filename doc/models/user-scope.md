
# User Scope

A type of creator and a matching identifier.

## Structure

`UserScope`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Type` | [`Type4Enum`](../../doc/models/type-4-enum.md) | Required | The type of user that created the resource. |
| `Id` | `string` | Required | A 24 character hex string used to identify a unique resource. |

## Example (as JSON)

```json
{
  "type": "environment",
  "id": "651586fca6078e98982dbd90"
}
```

