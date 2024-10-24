
# Fail On

## Structure

`FailOn`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Not` | `bool` | Required | If true, will fail on any codes NOT defined in the http_codes array. |
| `HttpCodes` | `List<int>` | Optional | A list of http response codes that will trigger a failure. |

## Example (as JSON)

```json
{
  "not": false,
  "http_codes": [
    236,
    237,
    238
  ]
}
```

