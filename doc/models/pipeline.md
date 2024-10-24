
# Pipeline

A pipeline resource.

## Structure

`Pipeline`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Id` | `string` | Required | A 24 character hex string used to identify a unique resource. |
| `Identifier` | `string` | Optional | A human-readable identifier used to refer to a resource, where using the official ID may be inconvenient.<br>The identifier is automatically tokenized from the name/relevant field of the resource if one is not provided. For example, a container named "My Container" will<br>have the identifier of `my-container` and is automatically created by the platform.<br><br>The identifier does not have to be unique. |
| `Name` | `string` | Required | A name for the pipeline. |
| `Creator` | [`CreatorScope`](../../doc/models/creator-scope.md) | Required | The creator scope is embedded in resource objects to describe who created them |
| `HubId` | `string` | Required | The unique ID of the Hub this resource was created in. |
| `Disable` | `bool` | Required | A boolean where true signifies the pipeline is disabled. |
| `MDynamic` | `bool` | Required | Setting to true enables variable and other advanced logic support on this pipeline. This is a one-way toggle. Once set to true, it cannot be set back to false. |
| `Stages` | [`List<PipelineStage>`](../../doc/models/pipeline-stage.md) | Optional | An array of stages. |
| `Events` | [`PipelineEvents`](../../doc/models/pipeline-events.md) | Required | A collection of timestamps for each event in the pipeline's lifetime. |
| `State` | [`PipelineState`](../../doc/models/pipeline-state.md) | Required | - |

## Example (as JSON)

```json
{
  "id": "651586fca6078e98982dbd90",
  "name": "name6",
  "creator": {
    "id": "651586fca6078e98982dbd90",
    "type": "employee"
  },
  "hub_id": "651586fca6078e98982dbd90",
  "disable": false,
  "dynamic": false,
  "events": {
    "created": "01/30/2021 08:30:00",
    "updated": "01/30/2021 08:30:00",
    "deleted": "01/30/2021 08:30:00",
    "last_run": "01/30/2021 08:30:00"
  },
  "state": {
    "current": "deleting",
    "changed": "01/30/2021 08:30:00",
    "error": {
      "message": "message4",
      "time": "2016-03-13T12:52:32.123Z"
    }
  },
  "identifier": "identifier6",
  "stages": [
    {
      "identifier": "identifier2",
      "steps": [
        {
          "action": "image.source.create",
          "identifier": "identifier8",
          "options": {
            "skip": false
          },
          "details": {
            "name": "name0",
            "type": "type0",
            "about": {
              "description": "description4"
            },
            "origin": {
              "type": "docker-hub",
              "details": {
                "existing": {
                  "source_id": "source_id8"
                },
                "target": "target8",
                "username": "username0",
                "token": "token4"
              }
            }
          }
        },
        {
          "action": "image.source.create",
          "identifier": "identifier8",
          "options": {
            "skip": false
          },
          "details": {
            "name": "name0",
            "type": "type0",
            "about": {
              "description": "description4"
            },
            "origin": {
              "type": "docker-hub",
              "details": {
                "existing": {
                  "source_id": "source_id8"
                },
                "target": "target8",
                "username": "username0",
                "token": "token4"
              }
            }
          }
        },
        {
          "action": "image.source.create",
          "identifier": "identifier8",
          "options": {
            "skip": false
          },
          "details": {
            "name": "name0",
            "type": "type0",
            "about": {
              "description": "description4"
            },
            "origin": {
              "type": "docker-hub",
              "details": {
                "existing": {
                  "source_id": "source_id8"
                },
                "target": "target8",
                "username": "username0",
                "token": "token4"
              }
            }
          }
        }
      ],
      "options": {
        "skip": false
      }
    }
  ]
}
```

