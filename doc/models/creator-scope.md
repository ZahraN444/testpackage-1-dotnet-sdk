
# Creator Scope

The creator scope is embedded in resource objects to describe who created them

## Structure

`CreatorScope`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Id` | `string` | Required | A 24 character hex string used to identify a unique resource. |
| `Type` | [`TypeEnum`](../../doc/models/type-enum.md) | Required | - |

## Example (as JSON)

```json
{
  "id": "651586fca6078e98982dbd90",
  "type": "account"
}
```

