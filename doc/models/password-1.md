
# Password 1

Password configuration settings for the remote access of the container volume.

## Structure

`Password1`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Algorithm` | [`Algorithm1Enum`](../../doc/models/algorithm-1-enum.md) | Required | The hashing algorithm used to has the password. |
| `Data` | `string` | Required | The raw or hashed password. |

## Example (as JSON)

```json
{
  "algorithm": "sha512",
  "data": "data6"
}
```

