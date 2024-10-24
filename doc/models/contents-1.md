
# Contents 1

Additional information the platform needs to create this job.

## Structure

`Contents1`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Enable` | `bool?` | Optional | A boolean where true means the VPN service is enabled. |
| `HighAvailability` | `bool?` | Optional | A boolean where `true` represents the desire to run the environment vpn service in high availability mode. |
| `AutoUpdate` | `bool?` | Optional | A boolean representing if this service container is set to autoupdate or not |
| `Config` | [`Config6`](../../doc/models/config-6.md) | Optional | The config object for the VPN service, in this case without the required fields normally found in a VPN config object. |

## Example (as JSON)

```json
{
  "enable": false,
  "high_availability": false,
  "auto_update": false,
  "config": {
    "allow_internet": false,
    "auth": {
      "webhook": "webhook4",
      "cycle_accounts": false,
      "vpn_accounts": false
    }
  }
}
```

