
# Shares 1

A share represents 1/10th of the available compute time on a single thread.

## Structure

`Shares1`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Limit` | `int` | Required | The limit (maximum) amount of shares each instance of a container can use. |
| `Reserve` | `int` | Required | The reserve (allocation) number of shares for each instance of a given container. |

## Example (as JSON)

```json
{
  "limit": 186,
  "reserve": 42
}
```

