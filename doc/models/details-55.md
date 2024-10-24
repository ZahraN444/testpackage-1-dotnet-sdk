
# Details 55

## Structure

`Details55`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Stack` | `string` | Required | An identifier used in pipelines to refer to different kinds of resources across Cycle.<br><br>## Types:<br><br>- `id:<mongo id>`: A raw resource ID<br>- `resource:<a resource identifier>`: A compound identifier pointing to a resource.<br>- `from:<stage/step>`: For referencing a previous pipeline step. |
| `Criteria` | [`Criteria`](../../doc/models/criteria.md) | Optional | - |

## Example (as JSON)

```json
{
  "stack": "- id:6515098637b66c233ed164e7\n- resource:cluster:dev,env:demo,container:api\n- from:/image-create\n",
  "criteria": {
    "expire": "expire4"
  }
}
```

