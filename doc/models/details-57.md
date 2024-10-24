
# Details 57

## Structure

`Details57`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Url` | `string` | Required | The url to submit a POST request to. |
| `Headers` | `Dictionary<string, string>` | Optional | An optional map of headers to send with the request. |
| `Options` | [`Details57Options`](../../doc/models/containers/details-57-options.md) | Optional | This is a container for any-of cases. |
| `Body` | `string` | Optional | An optional POST body to send with the request. Cannot be used with `from``. |
| `From` | `string` | Optional | Takes the output from a previous step and uses it as the body for the POST request. Cannot be used with `body`. String format is <stageIdentifier/stepIdentifier> |

## Example (as JSON)

```json
{
  "url": "url4",
  "from": "init/image-create",
  "headers": {
    "key0": "headers3",
    "key1": "headers4"
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
  },
  "body": "body6"
}
```

