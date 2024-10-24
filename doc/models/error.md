
# Error

The Cycle API uses standard HTTP response codes to indicate the success or failure of an API request. Codes in the `2xx` range indicate success. Codes in the `4xx` range indicate a request that failed due to input, and codes in the `5xx` range indicate an error on Cycle's part (rare).
There are two types of error response objects. Errors with authentication are formatted to follow the OAuth spec, while all other errors follow the same convention. If you're using one of our API Libraries, they will standardize OAuth errors to fit the general convention.

## Structure

`Error`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Status` | [`StatusEnum?`](../../doc/models/status-enum.md) | Optional | The HTTP response code. |
| `Code` | [`CodeEnum?`](../../doc/models/code-enum.md) | Optional | A Cycle standard error code. |
| `Title` | `string` | Optional | The main text describing the error. |
| `Detail` | `string` | Optional | A more detailed description of the error. |
| `Source` | `string` | Optional | A [JSON pointer](https://tools.ietf.org/html/rfc6901/) describing the source of an error. |
| `Extra` | [`Extra`](../../doc/models/extra.md) | Optional | Additional entries on the error object to provide extra details. |

## Example (as JSON)

```json
{
  "status": 409,
  "code": "404.ha_service_session",
  "title": "title0",
  "detail": "detail0",
  "source": "source0"
}
```

