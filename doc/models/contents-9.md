
# Contents 9

## Structure

`Contents9`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Config` | [`Contents9Config`](../../doc/models/containers/contents-9-config.md) | Optional | This is a container for any-of cases. |
| `HighAvailability` | `bool?` | Optional | A boolean where `true` represents the desire to run the environment discovery service in high availability mode. |
| `AutoUpdate` | `bool?` | Optional | A boolean where `true` represents the desire to automatically update the environment discovery service. |

## Example (as JSON)

```json
{
  "config": {
    "hosts": {
      "key0": {
        "ipv4": [
          "ipv42",
          "ipv43"
        ],
        "ipv6": [
          "ipv66",
          "ipv67",
          "ipv68"
        ]
      }
    }
  },
  "high_availability": false,
  "auto_update": false
}
```

