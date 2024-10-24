
# Caa

A DNS CAA record.

## Structure

`Caa`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Tag` | `string` | Required | The ASCII string that represents the identifier of the property represented by the record. |
| `MValue` | `string` | Required | The value associated with the tag. |

## Example (as JSON)

```json
{
  "tag": "tag4",
  "value": "value2"
}
```

