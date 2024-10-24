
# Error Envelope Exception

An error response.

## Structure

`ErrorEnvelopeException`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Error` | [`Error`](../../doc/models/error.md) | Required | The Cycle API uses standard HTTP response codes to indicate the success or failure of an API request. Codes in the `2xx` range indicate success. Codes in the `4xx` range indicate a request that failed due to input, and codes in the `5xx` range indicate an error on Cycle's part (rare).<br>There are two types of error response objects. Errors with authentication are formatted to follow the OAuth spec, while all other errors follow the same convention. If you're using one of our API Libraries, they will standardize OAuth errors to fit the general convention. |

## Example (as JSON)

```json
{
  "error": {
    "status": 403,
    "code": "422.missing_argument",
    "title": "title0",
    "detail": "detail0",
    "source": "source0"
  }
}
```

