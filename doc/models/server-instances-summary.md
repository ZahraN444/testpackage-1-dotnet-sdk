
# Server Instances Summary

A Server ID and number of Instances of a specific Container it hosts.

## Structure

`ServerInstancesSummary`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `ServerId` | `string` | Required | A 24 character hex string used to identify a unique resource. |
| `Instances` | `int` | Required | - |

## Example (as JSON)

```json
{
  "server_id": "651586fca6078e98982dbd90",
  "instances": 96
}
```

