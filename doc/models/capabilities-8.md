
# Capabilities 8

An object defining the capabilities of the given API key.

## Structure

`Capabilities8`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `All` | `bool` | Required | A boolean where true is giving the key all grantable capabilities. |
| `Specific` | [`List<CapabilityEnum>`](../../doc/models/capability-enum.md) | Required | An array of capabilites. |

## Example (as JSON)

```json
{
  "all": false,
  "specific": [
    "servers-provision",
    "servers-manage",
    "servers-view"
  ]
}
```

