
# Details 58

## Structure

`Details58`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Url` | `string` | Required | The url to submit a POST request to. |
| `Headers` | `Dictionary<string, string>` | Optional | An optional map of headers to send with the request. |
| `Options` | [`Details58Options`](../../doc/models/containers/details-58-options.md) | Optional | This is a container for any-of cases. |

## Example (as JSON)

```json
{
  "url": "url6",
  "headers": {
    "key0": "headers5",
    "key1": "headers6",
    "key2": "headers7"
  },
  "options": {
    "max_attempts": 166,
    "interval": "String9",
    "fail_on": {
      "not": false,
      "http_codes": [
        92,
        93,
        94
      ]
    },
    "retry_on": {
      "not": false,
      "http_codes": [
        52,
        53
      ]
    }
  }
}
```

