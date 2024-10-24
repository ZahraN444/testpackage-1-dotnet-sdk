
# V1 Containers Servers Response

## Structure

`V1ContainersServersResponse`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Data` | [`ServerInstancesSummary`](../../doc/models/server-instances-summary.md) | Required | A Server ID and number of Instances of a specific Container it hosts. |

## Example (as JSON)

```json
{
  "data": {
    "server_id": "651586fca6078e98982dbd90",
    "instances": 248
  }
}
```

