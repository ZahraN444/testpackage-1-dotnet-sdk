
# Billing Builds

An object holding information about servers included in Billing tier

## Structure

`BillingBuilds`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Parallel` | `double` | Required | - |
| `CpuCores` | `double` | Required | The number of CPU Cores availiable for builds |
| `RamGb` | `double` | Required | The amount of RAM availiable for builds |
| `MaxDailyBuilds` | `int?` | Required | The maximum number of builds processed per day |

## Example (as JSON)

```json
{
  "parallel": 173.2,
  "cpu_cores": 26.34,
  "ram_gb": 174.02,
  "max_daily_builds": 32
}
```

