
# Role Events

Timestamps for each event in the Role's lifetime.

## Structure

`RoleEvents`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Created` | `DateTime` | Required | The timestamp of when the Role source was created. |
| `Updated` | `DateTime` | Required | The timestamp of when the Role source was updated. |
| `Deleted` | `DateTime` | Required | The timestamp of when the Role source was deleted. |

## Example (as JSON)

```json
{
  "created": "01/30/2021 08:30:00",
  "updated": "01/30/2021 08:30:00",
  "deleted": "01/30/2021 08:30:00"
}
```

