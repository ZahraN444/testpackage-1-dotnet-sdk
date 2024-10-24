
# Container Network

Network configuration for a container.

## Structure

`ContainerNetwork`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Public` | [`Public1Enum`](../../doc/models/public-1-enum.md) | Required | The public network settings for the given container |
| `Hostname` | `string` | Required | The hostname for the given container. |
| `Ports` | `List<string>` | Optional | An array of port mappings for the container. |

## Example (as JSON)

```json
{
  "public": "disable",
  "hostname": "hostname0",
  "ports": [
    "ports9",
    "ports0"
  ]
}
```

