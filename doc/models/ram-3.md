
# Ram 3

Information about RAM Resources.

## Structure

`Ram3`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `TotalMb` | `int` | Required | The total amount of RAM in MBsr. |
| `AllocatedMb` | `int` | Required | The total amount of allocated RAM in MBs. |
| `UsedMb` | `int` | Required | The total amount of used RAM in MBs. |
| `ProvisionedMb` | `int?` | Optional | The total amount of provisioned RAM in MBs. |

## Example (as JSON)

```json
{
  "total_mb": 114,
  "allocated_mb": 202,
  "used_mb": 16,
  "provisioned_mb": 78
}
```

