
# Promo Code

A billing promo code.

## Structure

`PromoCode`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Code` | `string` | Required | The promo "code". |
| `Credit` | [`Dictionary<string, Credit>`](../../doc/models/credit.md) | Required | The amount of credit the promo code offers. |
| `State` | [`PromoCodeState`](../../doc/models/promo-code-state.md) | Required | - |

## Example (as JSON)

```json
{
  "code": "code2",
  "credit": {
    "key0": {
      "amount": {
        "mills": 240,
        "term": "yearly"
      },
      "expires": "2016-03-13T12:52:32.123Z"
    },
    "key1": {
      "amount": {
        "mills": 240,
        "term": "yearly"
      },
      "expires": "2016-03-13T12:52:32.123Z"
    },
    "key2": {
      "amount": {
        "mills": 240,
        "term": "yearly"
      },
      "expires": "2016-03-13T12:52:32.123Z"
    }
  },
  "state": {
    "current": "live",
    "changed": "01/30/2021 08:30:00",
    "error": {
      "message": "message4",
      "time": "2016-03-13T12:52:32.123Z"
    }
  }
}
```

