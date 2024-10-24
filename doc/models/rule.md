
# Rule

## Structure

`Rule`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Capabilities` | [`Capabilities3`](../../doc/models/capabilities-3.md) | Required | - |
| `Syscall` | [`Syscall`](../../doc/models/syscall.md) | Required | - |

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
    "action": "SCMP_ACT_TRAP",
    "errnoRet": 44,
    "args": [
      {
        "index": 218,
        "value": 146,
        "valuetwo": 212,
        "op": "SCMP_CMP_GT"
      }
    ]
  }
}
```

