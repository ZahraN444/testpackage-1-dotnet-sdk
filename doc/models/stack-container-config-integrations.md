
# Stack Container Config Integrations

## Structure

`StackContainerConfigIntegrations`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Webhooks` | [`Webhooks`](../../doc/models/webhooks.md) | Optional | - |
| `LetsEncrypt` | [`LetsEncrypt`](../../doc/models/lets-encrypt.md) | Optional | - |
| `Files` | [`List<File2>`](../../doc/models/file-2.md) | Optional | - |
| `Backups` | [`Backups`](../../doc/models/backups.md) | Optional | - |
| `SharedFileSystems` | [`Dictionary<string, SharedFileSystems>`](../../doc/models/shared-file-systems.md) | Optional | - |

## Example (as JSON)

```json
{
  "webhooks": {
    "events": {
      "deploy": "deploy2",
      "start": "start4",
      "stop": "stop2"
    },
    "config": "config2"
  },
  "lets_encrypt": {
    "enable": false,
    "certificate_path": "certificate_path4",
    "chain_path": "chain_path2",
    "key_path": "key_path0",
    "bundle_path": "bundle_path6",
    "additional_certs_path": "additional_certs_path4"
  },
  "files": [
    {
      "source": "source0",
      "destination": "destination0"
    }
  ],
  "backups": {
    "destination": "destination0",
    "backup": {
      "command": "command4",
      "timeout": "String9",
      "cron_string": "cron_string6"
    },
    "restore": {
      "command": "command8",
      "timeout": "String5"
    },
    "retention": "String7"
  },
  "shared_file_systems": {
    "key0": {
      "writable": false,
      "mount_point": "mount_point0"
    },
    "key1": {
      "writable": false,
      "mount_point": "mount_point0"
    }
  }
}
```

