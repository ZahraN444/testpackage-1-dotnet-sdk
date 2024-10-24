
# Scoped Variables

An object that describes configuration options for scoped variables on stack build.

## Structure

`ScopedVariables`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `AddNew` | `bool` | Required | Add new scoped variables defined in the stack. |
| `ReplaceExisting` | `bool` | Required | Replace all scoped variables with those defined in the stack. |

## Example (as JSON)

```json
{
  "add_new": false,
  "replace_existing": false
}
```

