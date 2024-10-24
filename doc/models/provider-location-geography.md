
# Provider Location Geography

Geographic information about a provider location.

## Structure

`ProviderLocationGeography`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Latitude` | `int` | Required | The latitude of the given provider datacenter. |
| `Longitude` | `int` | Required | The longitude of the given provider datacenter. |
| `City` | `string` | Required | The city the datacenter resides in. |
| `State` | `string` | Required | The state the datacenter resides in. |
| `Country` | `string` | Required | The country the datacenter resides in. |
| `Region` | `string` | Required | The region the datacenter resides in. |

## Example (as JSON)

```json
{
  "latitude": 10,
  "longitude": 46,
  "city": "city4",
  "state": "state0",
  "country": "country8",
  "region": "region0"
}
```

