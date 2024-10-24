
# Update 1

Configurations for container updates.

## Structure

`Update1`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Stagger` | `string` | Optional | When set, Cycle will pick a random time from `0 - this duration`, and stagger the instances so they all start at different times (up to the time specified here). |

## Example (as JSON)

```json
{
  "stagger": "72h45m2s"
}
```

