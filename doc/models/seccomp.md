
# Seccomp

## Structure

`Seccomp`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Disable` | `bool` | Required | - |
| `Rules` | [`List<Rule>`](../../doc/models/rule.md) | Required | - |

## Example (as JSON)

```json
{
  "disable": false,
  "rules": [
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
  ]
}
```

