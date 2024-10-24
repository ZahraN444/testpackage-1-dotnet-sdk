
# Ram 2

Configuration settings for limits and reserves of RAM resources for the given container.

## Structure

`Ram2`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Limit` | `string` | Optional | The limit (maximum) amount of RAM each instance of the given container can use. |
| `Reserve` | `string` | Optional | The reserve (allocation) of RAM given to each instance of the container. |

## Example (as JSON)

```json
{
  "limit": "1G, 2M",
  "reserve": "reserve2"
}
```

