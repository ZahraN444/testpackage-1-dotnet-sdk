
# SSH Token Events

A collection of timestamps for each event in the SSH token's lifetime.

## Structure

`SSHTokenEvents`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Created` | `DateTime` | Required | The timestamp of when the SSH token was created. |
| `Used` | `DateTime` | Required | The timestamp of when the SSH token was used. |
| `Expires` | `DateTime` | Required | The timestamp of when the SSH token expires. |

## Example (as JSON)

```json
{
  "created": "01/30/2021 08:30:00",
  "used": "01/30/2021 08:30:00",
  "expires": "01/30/2021 08:30:00"
}
```

