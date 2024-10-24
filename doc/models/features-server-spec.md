
# Features Server Spec

The spec for server features.

## Structure

`FeaturesServerSpec`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Raid` | `string` | Required | The type of RAID supported, if any. |
| `Aws` | [`Aws`](../../doc/models/aws.md) | Optional | Features specific to AWS. |

## Example (as JSON)

```json
{
  "raid": "raid4",
  "aws": {
    "ena_support": false,
    "ebs_optimized": false
  }
}
```

