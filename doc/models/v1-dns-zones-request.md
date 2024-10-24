
# V1 Dns Zones Request

## Structure

`V1DnsZonesRequest`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Hosted` | `bool` | Required | A boolean where true represents the desire for the origin to be of the type `hosted`. |
| `Origin` | `string` | Required | The origin that will be created. |

## Example (as JSON)

```json
{
  "hosted": false,
  "origin": "origin0"
}
```

