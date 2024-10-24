
# Details 30

## Structure

`Details30`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Id` | `string` | Required | - |
| `Origin` | [`ImageOrigin`](../../doc/models/containers/image-origin.md) | Required | The origin of the given image source. |

## Example (as JSON)

```json
{
  "id": "id8",
  "origin": {
    "type": "docker-hub",
    "details": {
      "existing": {
        "source_id": "source_id8"
      },
      "target": "target8",
      "username": "username0",
      "token": "token4"
    }
  }
}
```

