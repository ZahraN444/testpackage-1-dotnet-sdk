
# Override 3

An override object to be used for a single image create request.

## Structure

`Override3`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Target` | `string` | Optional | For image sources with `docker-hub` or `docker-registry` origin types. A target to be used for overridding the default target - should include an image and a tag. |
| `TargzUrl` | `string` | Optional | For image sources with `docker-file` origin types. A URL pointing to a .tar.gz file of a repo with a Dockerfile in it - can be used instead of linking Cycle directly to a repository. |

## Example (as JSON)

```json
{
  "target": "target0",
  "targz_url": "targz_url2"
}
```

