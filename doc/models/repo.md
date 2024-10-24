
# Repo

## Structure

`Repo`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Url` | `string` | Optional | The URL of the repository. |
| `Branch` | `string` | Optional | An optional branch arguement.  Default value is `master`. |
| `Auth` | [`RepoAuth`](../../doc/models/containers/repo-auth.md) | Optional | This is a container for one-of cases. |
| `Ref` | [`Ref`](../../doc/models/ref.md) | Optional | Repository reference information. |

## Example (as JSON)

```json
{
  "url": "url6",
  "branch": "branch8",
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
}
```

