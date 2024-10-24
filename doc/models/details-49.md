
# Details 49

## Structure

`Details49`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Environment` | `string` | Required | An identifier used in pipelines to refer to different kinds of resources across Cycle.<br><br>## Types:<br><br>- `id:<mongo id>`: A raw resource ID<br>- `resource:<a resource identifier>`: A compound identifier pointing to a resource.<br>- `from:<stage/step>`: For referencing a previous pipeline step. |
| `Tag` | `string` | Required | A human-readable identifier used to refer to a resource, where using the official ID may be inconvenient.<br>The identifier is automatically tokenized from the name/relevant field of the resource if one is not provided. For example, a container named "My Container" will<br>have the identifier of `my-container` and is automatically created by the platform.<br><br>The identifier does not have to be unique. |
| `Deployment` | [`Deployment5`](../../doc/models/deployment-5.md) | Required | - |

## Example (as JSON)

```json
{
  "environment": "- id:6515098637b66c233ed164e7\n- resource:cluster:dev,env:demo,container:api\n- from:/image-create\n",
  "tag": "tag8",
  "deployment": {
    "version": "v1.2.3-dev"
  }
}
```

