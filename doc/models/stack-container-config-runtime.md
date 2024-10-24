
# Stack Container Config Runtime

## Structure

`StackContainerConfigRuntime`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Workdir` | `string` | Optional | - |
| `Command` | [`Command`](../../doc/models/command.md) | Optional | - |
| `EnvironmentVars` | `Dictionary<string, string>` | Optional | - |
| `Namespaces` | [`List<NamespaceEnum>`](../../doc/models/namespace-enum.md) | Optional | - |
| `Sysctl` | `Dictionary<string, string>` | Optional | - |
| `Rlimits` | [`Dictionary<string, Rlimits>`](../../doc/models/rlimits.md) | Optional | - |
| `Seccomp` | [`Seccomp`](../../doc/models/seccomp.md) | Optional | - |
| `Host` | [`Host`](../../doc/models/host.md) | Optional | - |
| `Privileged` | `bool?` | Optional | - |
| `Capabilities` | [`List<Capabilities4Enum>`](../../doc/models/capabilities-4-enum.md) | Optional | - |
| `Rootfs` | [`Rootfs`](../../doc/models/rootfs.md) | Optional | - |

## Example (as JSON)

```json
{
  "workdir": "workdir0",
  "command": {
    "path": "path0",
    "args": "args6"
  },
  "environment_vars": {
    "key0": "environment_vars8",
    "key1": "environment_vars7"
  },
  "namespaces": [
    "mount",
    "user"
  ],
  "sysctl": {
    "key0": "sysctl8"
  }
}
```

