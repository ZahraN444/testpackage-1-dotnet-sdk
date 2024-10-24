
# Details 5

## Structure

`Details5`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Existing` | [`Details5Existing`](../../doc/models/containers/details-5-existing.md) | Optional | This is a container for any-of cases. |
| `Repo` | [`Details5Repo`](../../doc/models/containers/details-5-repo.md) | Optional | This is a container for any-of cases. |
| `TargzUrl` | `string` | Optional | An endpoint that serves the tar file. |
| `ContextDir` | `string` | Optional | The path to the directory to use as the context when building the image. |
| `BuildFile` | `string` | Optional | The path to the Dockerfile to be used for buiding the image. |
| `Credentials` | [`Details5Credentials`](../../doc/models/containers/details-5-credentials.md) | Optional | This is a container for any-of cases. |

## Example (as JSON)

```json
{
  "existing": {
    "source_id": "source_id8"
  },
  "repo": {
    "url": "url8",
    "branch": "branch0",
    "auth": {
      "type": "type0",
      "credentials": {
        "username": "username4",
        "password": "password0"
      }
    },
    "ref": {
      "type": "type0",
      "value": "value2"
    }
  },
  "targz_url": "targz_url4",
  "context_dir": "context_dir0",
  "build_file": "build_file4"
}
```

