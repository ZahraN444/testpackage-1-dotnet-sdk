
# Details 51

## Structure

`Details51`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Environment` | `string` | Required | An identifier used in pipelines to refer to different kinds of resources across Cycle.<br><br>## Types:<br><br>- `id:<mongo id>`: A raw resource ID<br>- `resource:<a resource identifier>`: A compound identifier pointing to a resource.<br>- `from:<stage/step>`: For referencing a previous pipeline step. |
| `Tag` | `string` | Optional | - |
| `Version` | `string` | Optional | - |
| `MaxWait` | [`Details51MaxWait`](../../doc/models/containers/details-51-max-wait.md) | Optional | This is a container for any-of cases. |

## Example (as JSON)

```json
{
  "environment": "- id:6515098637b66c233ed164e7\n- resource:cluster:dev,env:demo,container:api\n- from:/image-create\n",
  "tag": "tag4",
  "version": "version6",
  "max_wait": "String9"
}
```

