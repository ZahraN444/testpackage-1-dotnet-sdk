
# Container Stack Summary

A summary of the stack this container was created format.

## Structure

`ContainerStackSummary`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Id` | `string` | Optional | A 24 character hex string used to identify a unique resource. |
| `BuildId` | `string` | Optional | The ID of the stack build this container is associated with. |
| `Identifier` | `string` | Optional | The container identifier, usually the key to the container section of a stack file. |

## Example (as JSON)

```json
{
  "id": "651586fca6078e98982dbd90",
  "build_id": "build_id0",
  "identifier": "identifier2"
}
```
