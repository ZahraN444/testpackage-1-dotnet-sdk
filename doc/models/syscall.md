
# Syscall

## Structure

`Syscall`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Names` | `List<string>` | Required | - |
| `Action` | [`ActionEnum`](../../doc/models/action-enum.md) | Required | - |
| `ErrnoRet` | `int?` | Optional | - |
| `Args` | [`List<Arg>`](../../doc/models/arg.md) | Optional | - |

## Example (as JSON)

```json
{
  "names": [
    "names2",
    "names3"
  ],
  "action": "SCMP_ACT_KILL_THREAD",
  "errnoRet": 92,
  "args": [
    {
      "index": 218,
      "value": 146,
      "valuetwo": 212,
      "op": "SCMP_CMP_GT"
    },
    {
      "index": 218,
      "value": 146,
      "valuetwo": 212,
      "op": "SCMP_CMP_GT"
    }
  ]
}
```

