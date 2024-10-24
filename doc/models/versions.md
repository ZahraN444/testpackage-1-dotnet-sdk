
# Versions

## Structure

`Versions`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Tags` | `List<string>` | Required | An array of all tags on this environment that point to this version. |
| `Containers` | `int` | Required | The number of containers utilizing this version of this deployment. |

## Example (as JSON)

```json
{
  "tags": [
    "tags1",
    "tags2",
    "tags3"
  ],
  "containers": 234
}
```

