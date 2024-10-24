
# Details 4

## Structure

`Details4`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Existing` | [`Details4Existing`](../../doc/models/containers/details-4-existing.md) | Optional | This is a container for any-of cases. |
| `Target` | `string` | Required | The DockerHub target string. ex - `mysql:5.7` |
| `Username` | `string` | Optional | For authentication, a username. |
| `Token` | `string` | Optional | For authentication, a token. |

## Example (as JSON)

```json
{
  "existing": {
    "source_id": "source_id8"
  },
  "target": "target8",
  "username": "username6",
  "token": "token2"
}
```

