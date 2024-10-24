
# V1 Account Password Request

## Structure

`V1AccountPasswordRequest`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Current` | `string` | Required | Current Password |
| `New` | `string` | Required | New Password<br>**Constraints**: *Minimum Length*: `8` |

## Example (as JSON)

```json
{
  "current": "current2",
  "new": "new4"
}
```

