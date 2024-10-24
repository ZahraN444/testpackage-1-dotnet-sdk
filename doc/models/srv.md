
# Srv

A DNS SRV record.

## Structure

`Srv`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Weight` | `int` | Required | Teh weight configured for this record - breaks ties for priority. |
| `Priority` | `int` | Required | The priority for the record. |
| `Port` | `int` | Required | The port number for the service. |
| `Domain` | `string` | Required | The domain for the record. |

## Example (as JSON)

```json
{
  "weight": 164,
  "priority": 230,
  "port": 200,
  "domain": "domain2"
}
```

