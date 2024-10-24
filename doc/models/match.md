
# Match

The ruleset for this router to be selected. If both ``domains`` and``internal_port` are null, then this match acts as a wildcard and will match all.

## Structure

`Match`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Domains` | `List<string>` | Required | The specific domains to match against. |
| `InternalPort` | `List<int>` | Required | The specific ports to match against. |
| `Path` | `string` | Optional | - |

## Example (as JSON)

```json
{
  "domains": [
    "domains8",
    "domains9"
  ],
  "internal_port": [
    203,
    204
  ],
  "path": "path2"
}
```

