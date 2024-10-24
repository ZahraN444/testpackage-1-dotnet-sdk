
# Capabilities 1

The list of platform level capabilities assigned to this Role.

## Structure

`Capabilities1`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `All` | `bool` | Required | If true, the Role has all capabilities. |
| `Specific` | [`List<CapabilityEnum>`](../../doc/models/capability-enum.md) | Required | - |

## Example (as JSON)

```json
{
  "all": false,
  "specific": [
    "hubs-members-view"
  ]
}
```

