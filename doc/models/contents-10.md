
# Contents 10

## Structure

`Contents10`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Config` | [`Contents10Config`](../../doc/models/containers/contents-10-config.md) | Optional | This is a container for any-of cases. |
| `AutoUpdate` | `bool?` | Optional | A boolean where `true` represents the desire to automatically update the environment scheduler service. |

## Example (as JSON)

```json
{
  "config": {
    "public": false,
    "access_keys": [
      {
        "name": "name4",
        "secret": "secret0",
        "ips": [
          "ips8"
        ]
      }
    ]
  },
  "auto_update": false
}
```

