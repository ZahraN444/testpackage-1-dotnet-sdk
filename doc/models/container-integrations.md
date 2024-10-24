
# Container Integrations

Configuration settings for integrations with a given container.

## Structure

`ContainerIntegrations`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Webhooks` | [`Webhooks1`](../../doc/models/webhooks-1.md) | Optional | Webhooks that can be set for specific event reporting and advanced container configurations. |
| `Files` | [`List<File4>`](../../doc/models/file-4.md) | Optional | Inject remotely hosted files into container instances at runtime. |
| `LetsEncrypt` | [`LetsEncrypt1`](../../doc/models/lets-encrypt-1.md) | Optional | Configuration settings to embed a TLS certificate in the container. |
| `Backups` | [`Backups1`](../../doc/models/backups-1.md) | Optional | Automated backups configuration for the given container. |
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
  "files": [
    {
      "source": "source0",
      "destination": "destination0"
    },
    {
      "source": "source0",
      "destination": "destination0"
    }
  ],
  "lets_encrypt": {
    "enable": false,
    "certificate_path": "certificate_path4",
    "chain_path": "chain_path2",
    "key_path": "key_path0",
    "bundle_path": "bundle_path6",
    "additional_certs_path": "additional_certs_path4"
  },
  "backups": {
    "integration_id": "integration_id6",
    "backup": {
      "command": "command4",
      "timeout": "String9",
      "cron_string": "cron_string6"
    },
    "restore": {
      "command": "command8",
      "timeout": "timeout4"
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
    },
    "key2": {
      "writable": false,
      "mount_point": "mount_point0"
    }
  }
}
```

