
# Capabilities 10

The list of platform level capabilities assigned to this Role.

## Structure

`Capabilities10`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `All` | `bool` | Required | - |
| `Specific` | [`List<CapabilityEnum>`](../../doc/models/capability-enum.md) | Required | - |

## Example (as JSON)

```json
{
  "all": false,
  "specific": [
    "containers-manage"
  ]
}
```

