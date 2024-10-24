
# Integration

## Structure

`Integration`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Id` | `string` | Required | A 24 character hex string used to identify a unique resource. |
| `Name` | `string` | Optional | Name of the Integration. |
| `Vendor` | `string` | Required | Which vendor this Integration is associated with. |
| `Identifier` | `string` | Required | A human-readable identifier used to refer to a resource, where using the official ID may be inconvenient.<br>The identifier is automatically tokenized from the name/relevant field of the resource if one is not provided. For example, a container named "My Container" will<br>have the identifier of `my-container` and is automatically created by the platform.<br><br>The identifier does not have to be unique. |
| `Auth` | [`IntegrationAuth2`](../../doc/models/containers/integration-auth-2.md) | Optional | This is a container for any-of cases. |
| `Extra` | `Dictionary<string, string>` | Optional | Additional key-value pairs associated with the Integration. |
| `Creator` | [`CreatorScope`](../../doc/models/creator-scope.md) | Required | The creator scope is embedded in resource objects to describe who created them |
| `HubId` | `string` | Required | Identifier of the hub associated with the Integration. |
| `State` | [`IntegrationState`](../../doc/models/integration-state.md) | Required | - |
| `Events` | [`IntegrationEvents`](../../doc/models/integration-events.md) | Required | A collection of timestamps for each event in the Integration's lifetime. |
| `Meta` | [`IntegrationMeta2`](../../doc/models/containers/integration-meta-2.md) | Optional | This is a container for any-of cases. |

## Example (as JSON)

```json
{
  "id": "651586fca6078e98982dbd90",
  "vendor": "vendor2",
  "identifier": "identifier6",
  "creator": {
    "id": "651586fca6078e98982dbd90",
    "type": "employee"
  },
  "hub_id": "651586fca6078e98982dbd90",
  "state": {
    "current": "live",
    "changed": "01/30/2021 08:30:00",
    "error": {
      "message": "message4",
      "time": "2016-03-13T12:52:32.123Z"
    }
  },
  "events": {
    "created": "01/30/2021 08:30:00",
    "updated": "01/30/2021 08:30:00",
    "deleted": "01/30/2021 08:30:00"
  },
  "name": "name6",
  "auth": {
    "region": "region2",
    "namespace": "namespace6",
    "api_key": "api_key6",
    "key_id": "key_id2",
    "secret": "secret8"
  },
  "extra": {
    "key0": "extra2",
    "key1": "extra3"
  },
  "meta": {
    "definition": {
      "vendor": "vendor6",
      "name": "name0",
      "supports_verification": false,
      "supports_multiple": false,
      "features": [
        "features1",
        "features2",
        "features3"
      ],
      "extends": [
        "extends4",
        "extends5",
        "extends6"
      ],
      "extended_configuration": {
        "options": [
          {
            "title": "title2",
            "key": "key2",
            "type": "type8"
          },
          {
            "title": "title2",
            "key": "key2",
            "type": "type8"
          },
          {
            "title": "title2",
            "key": "key2",
            "type": "type8"
          }
        ]
      },
      "fields": {
        "extra": {
          "key0": {
            "regex": "regex4",
            "required": false,
            "description": "description6"
          },
          "key1": {
            "regex": "regex4",
            "required": false,
            "description": "description6"
          }
        },
        "auth": {
          "key0": {
            "regex": "regex4",
            "required": false,
            "description": "description6"
          },
          "key1": {
            "regex": "regex4",
            "required": false,
            "description": "description6"
          }
        }
      },
      "url": "url4",
      "public": false,
      "usable": false,
      "editable": false
    }
  }
}
```

