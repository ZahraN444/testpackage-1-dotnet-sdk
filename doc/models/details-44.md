
# Details 44

## Structure

`Details44`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Environment` | `string` | Required | An identifier used in pipelines to refer to different kinds of resources across Cycle.<br><br>## Types:<br><br>- `id:<mongo id>`: A raw resource ID<br>- `resource:<a resource identifier>`: A compound identifier pointing to a resource.<br>- `from:<stage/step>`: For referencing a previous pipeline step. |

## Example (as JSON)

```json
{
  "environment": "- id:6515098637b66c233ed164e7\n- resource:cluster:dev,env:demo,container:api\n- from:/image-create\n"
}
```

