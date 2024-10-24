
# Mx

A DNS MX record

## Structure

`Mx`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Priority` | `int` | Required | The priority setting for this mx record. |
| `Domain` | `string` | Required | The domain this mx record points to. |

## Example (as JSON)

```json
{
  "priority": 236,
  "domain": "domain4"
}
```

