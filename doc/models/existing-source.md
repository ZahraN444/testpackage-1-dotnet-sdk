
# Existing Source

In a stack, specifies an image source ID from which Cycle will derive any values not specified in the stack file. This is useful for avoiding direct placement of credentials in a stack file, for example.

## Structure

`ExistingSource`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `SourceId` | `string` | Optional | The ID of the image source this image should be built from. |

## Example (as JSON)

```json
{
  "source_id": "651586fca6078e98982dbd90"
}
```

