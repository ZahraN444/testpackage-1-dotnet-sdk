
# V1 Containers Instances Request

## Structure

`V1ContainersInstancesRequest`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `ServerId` | `string` | Required | The ID of the Server the new Instance(s) should be deployed to. |
| `NewInstances` | `int` | Required | The number of new Instances to be created on the given Server. |

## Example (as JSON)

```json
{
  "server_id": "server_id0",
  "new_instances": 196
}
```

