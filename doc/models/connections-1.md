
# Connections 1

## Structure

`Connections1`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Success` | `int` | Required | - |
| `Unavailable` | `int` | Required | - |
| `Errors` | `Dictionary<string, int>` | Optional | - |
| `BytesTransmitted` | `int?` | Optional | - |
| `BytesReceived` | `int?` | Optional | - |

## Example (as JSON)

```json
{
  "success": 48,
  "unavailable": 196,
  "errors": {
    "key0": 249,
    "key1": 250,
    "key2": 251
  },
  "bytes_transmitted": 212,
  "bytes_received": 166
}
```

