
# Seccomp Rule

Rules for controlling Linux seccomp inside a container.

## Structure

`SeccompRule`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Capabilities` | [`Capabilities5`](../../doc/models/capabilities-5.md) | Optional | - |
| `Syscall` | [`Syscall1`](../../doc/models/syscall-1.md) | Optional | LinuxSyscall is used to match a syscall in Seccomp |

## Example (as JSON)

```json
{
  "capabilities": {
    "includes": "includes4",
    "excludes": "excludes8"
  },
  "syscall": {
    "names": [
      "names8",
      "names9",
      "names0"
    ],
    "action": "action0",
    "errnoRet": 44,
    "args": [
      {
        "index": 218,
        "value": 146,
        "valueTwo": 82,
        "op": "op4"
      }
    ]
  }
}
```

