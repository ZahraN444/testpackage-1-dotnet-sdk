
# Contents 2

Additional information needed to complete the job.

## Structure

`Contents2`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `ImageId` | `string` | Required | The ID of the image to use when reimaging. |
| `AllowIncompatible` | `bool?` | Optional | A boolean where true signifies the image being used to reimage does not have to have compatibility with the image being replaced. |
| `OverwriteRuntimeConfig` | `bool?` | Optional | A boolean where true signifies the user wishes to overwrite the current runtime configuration for the given container during the reimage process. |

## Example (as JSON)

```json
{
  "image_id": "image_id6",
  "allow_incompatible": false,
  "overwrite_runtime_config": false
}
```

