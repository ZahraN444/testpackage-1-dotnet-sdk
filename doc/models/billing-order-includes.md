
# Billing Order Includes

## Structure

`BillingOrderIncludes`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `PromoCodes` | [`Dictionary<string, PromoCode>`](../../doc/models/promo-code.md) | Optional | A resource thats associated with a promo code. |

## Example (as JSON)

```json
{
  "promo_codes": {
    "key0": {
      "code": "code0",
      "credit": {
        "key0": {
          "amount": {
            "mills": 240,
            "term": "yearly"
          },
          "expires": "2016-03-13T12:52:32.123Z"
        }
      },
      "state": {
        "current": "live",
        "changed": "2016-03-13T12:52:32.123Z",
        "error": {
          "message": "message4",
          "time": "2016-03-13T12:52:32.123Z"
        }
      }
    },
    "key1": {
      "code": "code0",
      "credit": {
        "key0": {
          "amount": {
            "mills": 240,
            "term": "yearly"
          },
          "expires": "2016-03-13T12:52:32.123Z"
        }
      },
      "state": {
        "current": "live",
        "changed": "2016-03-13T12:52:32.123Z",
        "error": {
          "message": "message4",
          "time": "2016-03-13T12:52:32.123Z"
        }
      }
    },
    "key2": {
      "code": "code0",
      "credit": {
        "key0": {
          "amount": {
            "mills": 240,
            "term": "yearly"
          },
          "expires": "2016-03-13T12:52:32.123Z"
        }
      },
      "state": {
        "current": "live",
        "changed": "2016-03-13T12:52:32.123Z",
        "error": {
          "message": "message4",
          "time": "2016-03-13T12:52:32.123Z"
        }
      }
    }
  }
}
```

