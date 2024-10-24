
# Details 33

## Structure

`Details33`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Name` | `string` | Optional | - |
| `Source` | `string` | Required | An identifier used in pipelines to refer to different kinds of resources across Cycle.<br><br>## Types:<br><br>- `id:<mongo id>`: A raw resource ID<br>- `resource:<a resource identifier>`: A compound identifier pointing to a resource.<br>- `from:<stage/step>`: For referencing a previous pipeline step. |
| `Build` | [`Build2`](../../doc/models/build-2.md) | Optional | Optional build-time options for when this image is built on pipeline run. |
| `Override` | [`Override3`](../../doc/models/override-3.md) | Optional | An override object to be used for a single image create request. |

## Example (as JSON)

```json
{
  "source": "- id:6515098637b66c233ed164e7\n- resource:cluster:dev,env:demo,container:api\n- from:/image-create\n",
  "name": "name2",
  "build": {
    "args": {
      "key0": "args9"
    }
  },
  "override": {
    "target": "target2",
    "targz_url": "targz_url0"
  }
}
```

