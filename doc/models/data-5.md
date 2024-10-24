
# Data 5

Credentials for connecting to the instance telemetry stream on compute.

## Structure

`Data5`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Token` | `string` | Required | The authentication token passed into the address as a URL parameter (?token). |
| `Address` | `string` | Required | The URL address to open a websocket to for streaming instance telemetry data. |

## Example (as JSON)

```json
{
  "token": "token6",
  "address": "address6"
}
```

