
# Details 29

## Structure

`Details29`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Id` | `string` | Required | - |
| `StackId` | `string` | Required | - |
| `Containers` | `List<string>` | Required | - |
| `Origin` | [`ImageOrigin`](../../doc/models/containers/image-origin.md) | Required | The origin of the given image source. |

## Example (as JSON)

```json
{
  "id": "id8",
  "stack_id": "stack_id8",
  "containers": [
    "containers3"
  ],
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

