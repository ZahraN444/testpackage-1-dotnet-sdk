
# Mounts

## Structure

`Mounts`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Type` | `string` | Required | String describing the server mount type. |
| `Options` | `string` | Required | Comma separated string describing the server mount options. |
| `Source` | `string` | Required | String describing the server mount source. |

## Example (as JSON)

```json
{
  "type": "type8",
  "options": "key1=value1,key2=value2",
  "source": "source2"
}
```

