
# Huge TLB

HugeTLB data.

## Structure

`HugeTLB`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Usage` | `int?` | Optional | The number of bytes being consumed by huge pages of all sizes. |
| `Max` | `int?` | Optional | The maximum number of bytes allowed to be used for huge pages for this instance. |
| `FailCount` | `int?` | Optional | The number of times the hugeTLB memory limit has been exceeded by this instance. |

## Example (as JSON)

```json
{
  "usage": 52,
  "max": 108,
  "fail_count": 182
}
```

