
# Data 1

## Structure

`Data1`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Versions` | [`Dictionary<string, Versions>`](../../doc/models/versions.md) | Required | A map where the key is the version property of a deployment. |

## Example (as JSON)

```json
{
  "versions": {
    "key0": {
      "tags": [
        "tags5",
        "tags6"
      ],
      "containers": 16
    },
    "key1": {
      "tags": [
        "tags5",
        "tags6"
      ],
      "containers": 16
    }
  }
}
```

