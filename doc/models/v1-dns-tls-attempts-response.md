
# V1 Dns Tls Attempts Response

## Structure

`V1DnsTlsAttemptsResponse`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Data` | [`List<DNSTLSAttempt>`](../../doc/models/dnstls-attempt.md) | Required | - |

## Example (as JSON)

```json
{
  "data": [
    {
      "id": "651586fca6078e98982dbd90",
      "hub_id": "651586fca6078e98982dbd90",
      "domains": [
        "domains0",
        "domains1",
        "domains2"
      ],
      "time": "01/30/2021 08:30:00",
      "success": false,
      "error": "error4"
    }
  ]
}
```

