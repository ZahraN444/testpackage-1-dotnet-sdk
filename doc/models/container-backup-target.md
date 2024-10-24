
# Container Backup Target

A target for the given Container Backup.

## Structure

`ContainerBackupTarget`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `IntegrationId` | `string` | Required | Either a resource ID (objectid - i.e. 651586fca6078e98982dbd90) or a resource Identifier (human-readable) |
| `Path` | `string` | Required | The target for where to store the Container Backup on the destination service. |
| `FileId` | `string` | Required | - |
| `Size` | `int` | Required | The total size of the backup. |

## Example (as JSON)

```json
{
  "integration_id": "my-image-source",
  "path": "path8",
  "file_id": "file_id0",
  "size": 214
}
```

