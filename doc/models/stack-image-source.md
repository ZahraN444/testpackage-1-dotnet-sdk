
# Stack Image Source

## Structure

`StackImageSource`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Type` | [`Type8Enum?`](../../doc/models/type-8-enum.md) | Optional | - |
| `Details` | [`Details29`](../../doc/models/details-29.md) | Optional | - |
| `Override` | [`Override`](../../doc/models/override.md) | Optional | - |

## Example (as JSON)

```json
{
  "type": "stack-build",
  "details": {
    "id": "id0",
    "stack_id": "stack_id0",
    "containers": [
      "containers7",
      "containers8"
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
  },
  "override": {
    "target": "target2",
    "targz_url": "targz_url0"
  }
}
```

