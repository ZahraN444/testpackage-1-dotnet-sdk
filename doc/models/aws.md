
# Aws

Features specific to AWS.

## Structure

`Aws`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `EnaSupport` | `bool` | Required | A boolean where true indicates this is a machine that can support a much higher networking throughput. |
| `EbsOptimized` | `bool` | Required | A boolean where true indicates this is a machine that can support higher storage throughput. |

## Example (as JSON)

```json
{
  "ena_support": false,
  "ebs_optimized": false
}
```

