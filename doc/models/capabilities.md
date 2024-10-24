
# Capabilities

## Structure

`Capabilities`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `All` | `bool` | Required | - |
| `Specific` | [`List<CapabilityEnum>`](../../doc/models/capability-enum.md) | Optional | - |

## Example (as JSON)

```json
{
  "all": false,
  "specific": [
    "environments-vpn-manage",
    "hubs-delete",
    "hubs-integrations-manage"
  ]
}
```

