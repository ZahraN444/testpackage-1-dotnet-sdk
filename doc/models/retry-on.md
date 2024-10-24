
# Retry On

## Structure

`RetryOn`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Not` | `bool` | Required | If true, will retry on any codes NOT defined in the http_codes array. |
| `HttpCodes` | `List<int>` | Optional | A list of http response codes that will trigger a retry. |

## Example (as JSON)

```json
{
  "not": false,
  "http_codes": [
    134,
    135
  ]
}
```

