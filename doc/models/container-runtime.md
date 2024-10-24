
# Container Runtime

Runtime configurations for a given container.

## Structure

`ContainerRuntime`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Command` | [`Command1`](../../doc/models/command-1.md) | Optional | A command that will be run in place of the images defined startup command. |
| `Namespaces` | [`List<NamespaceEnum>`](../../doc/models/namespace-enum.md) | Optional | Namespaces the given container will have access to. |
| `EnvironmentVars` | `Dictionary<string, string>` | Optional | A record of environment variables for the given container. |
| `Privileged` | `bool` | Required | Selecting this option will give this container full permissions on the server. This is not recommended and increases the likelihood of your server being compromised. |
| `Capabilities` | [`List<Capabilities4Enum>`](../../doc/models/capabilities-4-enum.md) | Optional | A list of linux kernel capabilites for the given container. |
| `Workdir` | `string` | Optional | Configure the working directory for the given container. |
| `Sysctl` | `Dictionary<string, string>` | Optional | A record of sysctl fields and values for a given container. |
| `Rlimits` | [`Dictionary<string, Rlimits1>`](../../doc/models/rlimits-1.md) | Optional | A record of rlimits and their values. |
| `Seccomp` | [`Seccomp1`](../../doc/models/seccomp-1.md) | Optional | - |
| `Host` | [`Host`](../../doc/models/host.md) | Optional | - |
| `Rootfs` | [`Rootfs1`](../../doc/models/rootfs-1.md) | Optional | - |

## Example (as JSON)

```json
{
  "command": {
    "path": "path0",
    "args": "args6"
  },
  "namespaces": [
    "uts"
  ],
  "environment_vars": {
    "key0": "environment_vars2",
    "key1": "environment_vars3",
    "key2": "environment_vars4"
  },
  "privileged": false,
  "capabilities": [
    "CAP_SYS_RESOURCE"
  ],
  "workdir": "workdir0"
}
```

