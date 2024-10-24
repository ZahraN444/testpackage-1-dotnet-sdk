
# Repo Source Type

Information about the repostiory.

## Structure

`RepoSourceType`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Url` | `string` | Required | The URL of the repository. |
| `Branch` | `string` | Optional | An optional branch arguement.  Default value is `master`. |
| `Auth` | [`RepoSourceTypeAuth`](../../doc/models/containers/repo-source-type-auth.md) | Optional | This is a container for one-of cases. |
| `Ref` | [`Ref`](../../doc/models/ref.md) | Optional | Repository reference information. |

## Example (as JSON)

```json
{
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
}
```

