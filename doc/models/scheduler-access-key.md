
# Scheduler Access Key

Custom authorization keys for the scheduler service.

## Structure

`SchedulerAccessKey`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Name` | `string` | Required | The name given to this access key |
| `Secret` | `string` | Required | The access key secret. This should be submitted with requests to a publicly accessible scheduler service. |
| `Ips` | `List<string>` | Optional | Whitelisted IPs that are allowed to make requests to the scheduler service. |

## Example (as JSON)

```json
{
  "name": "name6",
  "secret": "secret2",
  "ips": [
    "ips0",
    "ips1"
  ]
}
```

