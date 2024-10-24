
# Tier 1

Image tier information.

## Structure

`Tier1`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `TotalMb` | `int` | Required | A value in MB representing the total MB of space on the infrastructure available for images. |
| `AllocatedMb` | `int` | Required | A value in MB representing the amount of allocated space for images. |
| `UsedMb` | `int` | Required | A value in MB representing the total MB of space images are taking up out of the total megabytes available. |

## Example (as JSON)

```json
{
  "total_mb": 174,
  "allocated_mb": 6,
  "used_mb": 76
}
```

