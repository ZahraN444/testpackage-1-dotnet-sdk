
# Syscall 1

LinuxSyscall is used to match a syscall in Seccomp

## Structure

`Syscall1`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Names` | `List<string>` | Required | - |
| `Action` | `string` | Required | - |
| `ErrnoRet` | `int?` | Optional | - |
| `Args` | [`List<Arg1>`](../../doc/models/arg-1.md) | Optional | - |

## Example (as JSON)

```json
{
  "names": [
    "names4",
    "names5"
  ],
  "action": "action6",
  "errnoRet": 148,
  "args": [
    {
      "index": 218,
      "value": 146,
      "valueTwo": 82,
      "op": "op4"
    },
    {
      "index": 218,
      "value": 146,
      "valueTwo": 82,
      "op": "op4"
    }
  ]
}
```

