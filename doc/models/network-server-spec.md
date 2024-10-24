
# Network Server Spec

Information about the network resources for a given server.

## Structure

`NetworkServerSpec`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Count` | `int` | Required | The number of network resources for a given server. |
| `Scope` | [`Scope1Enum`](../../doc/models/scope-1-enum.md) | Required | The scope of the interfaces. |
| `Throughput` | `int` | Required | The network throughput in MB(per second). |
| `Type` | `string` | Required | The type of the NIC. |

## Example (as JSON)

```json
{
  "count": 190,
  "scope": "shared",
  "throughput": 88,
  "type": "type2"
}
```

