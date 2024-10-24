
# Details 19

## Structure

`Details19`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Private` | `bool` | Required | - |
| `Bandwidth` | `string` | Required | The limit (maximum) amount of throughput each instance of the given container can use before triggering a scaling event. |

## Example (as JSON)

```json
{
  "private": false,
  "bandwidth": "1G, 2M"
}
```

