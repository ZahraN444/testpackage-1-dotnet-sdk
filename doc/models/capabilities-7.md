
# Capabilities 7

An object holding information about the capabilities of this API key.

## Structure

`Capabilities7`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `All` | `bool` | Required | A boolean where true represents this key has all available capabilities. |
| `Specific` | [`List<CapabilityEnum>`](../../doc/models/capability-enum.md) | Required | An array a capabilities this key has. |

## Example (as JSON)

```json
{
  "all": false,
  "specific": [
    "servers-console",
    "servers-decommission",
    "servers-login"
  ]
}
```

