
# Redirect

Defines a built-in redirect for HTTP mode routers

## Structure

`Redirect`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `AutoHttpsRedirect` | `bool` | Required | If enabled and a sibling controller exists for port 443, requests will be auto redirected to it. Essentially sets up automatic TLS redirection for this router. |
| `RemoveWww` | `bool` | Required | If true, any request comes in with "www" prefix will be permanently redirected to the same path without www. |
| `Port` | `int?` | Optional | The port to redirect traffic to. |
| `Scheme` | `string` | Optional | The scheme to redirect to. (i.e. `https`) |
| `Url` | `string` | Optional | A specific URL to redirect to. |

## Example (as JSON)

```json
{
  "auto_https_redirect": false,
  "remove_www": false,
  "port": 164,
  "scheme": "scheme6",
  "url": "url0"
}
```

