
# Direct Image Source

## Structure

`DirectImageSource`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Type` | [`Type9Enum?`](../../doc/models/type-9-enum.md) | Optional | - |
| `Details` | [`Details30`](../../doc/models/details-30.md) | Optional | - |
| `Override` | [`Override`](../../doc/models/override.md) | Optional | - |

## Example (as JSON)

```json
{
  "type": "direct",
  "details": {
    "id": "id0",
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

