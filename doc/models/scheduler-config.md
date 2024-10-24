
# Scheduler Config

Configuration options for the scheduler Environment service.

## Structure

`SchedulerConfig`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Public` | `bool` | Required | If true, the scheduler service API will be exposed publicly via the load balancer. This is useful for allowing external services spin up function containers using custom logic. |
| `AccessKeys` | [`List<SchedulerAccessKey>`](../../doc/models/scheduler-access-key.md) | Optional | - |

## Example (as JSON)

```json
{
  "public": false,
  "access_keys": [
    {
      "name": "name4",
      "secret": "secret0",
      "ips": [
        "ips8"
      ]
    }
  ]
}
```

