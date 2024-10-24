
# Details 54

## Structure

`Details54`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Build` | `string` | Required | An identifier used in pipelines to refer to different kinds of resources across Cycle.<br><br>## Types:<br><br>- `id:<mongo id>`: A raw resource ID<br>- `resource:<a resource identifier>`: A compound identifier pointing to a resource.<br>- `from:<stage/step>`: For referencing a previous pipeline step. |
| `Environment` | `string` | Required | An identifier used in pipelines to refer to different kinds of resources across Cycle.<br><br>## Types:<br><br>- `id:<mongo id>`: A raw resource ID<br>- `resource:<a resource identifier>`: A compound identifier pointing to a resource.<br>- `from:<stage/step>`: For referencing a previous pipeline step. |
| `Update` | [`Details54Update`](../../doc/models/containers/details-54-update.md) | Optional | This is a container for any-of cases. |
| `Deployment` | [`Details54Deployment`](../../doc/models/containers/details-54-deployment.md) | Optional | This is a container for any-of cases. |

## Example (as JSON)

```json
{
  "build": "- id:6515098637b66c233ed164e7\n- resource:cluster:dev,env:demo,container:api\n- from:/image-create\n",
  "environment": "- id:6515098637b66c233ed164e7\n- resource:cluster:dev,env:demo,container:api\n- from:/image-create\n",
  "update": {
    "containers": {
      "key0": {
        "reimage": false,
        "reconfigure": false
      }
    },
    "scoped_variables": {
      "add_new": false,
      "replace_existing": false
    }
  },
  "deployment": {
    "version": "version0"
  }
}
```

