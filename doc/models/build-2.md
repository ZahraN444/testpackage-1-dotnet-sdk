
# Build 2

Optional build-time options for when this image is built on pipeline run.

## Structure

`Build2`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Args` | `Dictionary<string, string>` | Optional | Build args passed into the container image build process during pipeline run. |

## Example (as JSON)

```json
{
  "args": {
    "key0": "args1"
  }
}
```

