
# Seccomp 1

## Structure

`Seccomp1`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Disable` | `bool?` | Optional | - |
| `Rules` | [`List<SeccompRule>`](../../doc/models/seccomp-rule.md) | Optional | - |

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
    },
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
  ]
}
```

