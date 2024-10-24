
# Details 13

## Structure

`Details13`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Url` | `string` | Required | The URL to call to produce the value. |
| `Headers` | `object` | Required | Additional headers that can be attached to the URL request. Useful for adding metadata to third-party services. |
| `AuthTokenUrl` | `string` | Required | A URL that can be provided to authenticate with a third party secret service. Cycle will make a request to this URL before fetching the secret URL, and use the response as the value of an Authorization header when requesting the secret. |

## Example (as JSON)

```json
{
  "url": "url6",
  "headers": {
    "key0": {
      "key1": "val1",
      "key2": "val2"
    }
  },
  "auth_token_url": "auth_token_url4"
}
```

