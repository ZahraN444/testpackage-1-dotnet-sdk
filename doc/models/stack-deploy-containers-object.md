
# Stack Deploy Containers Object

Options to control how a container behaves when a stack build is deployed.

## Structure

`StackDeployContainersObject`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Reimage` | `bool` | Required | A boolean where true represents the container is to be reimaged. |
| `Reconfigure` | `bool` | Required | A boolean where true represents the container is to be reconfigured. |

## Example (as JSON)

```json
{
  "reimage": false,
  "reconfigure": false
}
```

