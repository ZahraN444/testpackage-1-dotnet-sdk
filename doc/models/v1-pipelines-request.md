
# V1 Pipelines Request

## Structure

`V1PipelinesRequest`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Name` | `string` | Required | A name for the Pipeline. |
| `Identifier` | `string` | Optional | A human-readable identifier used to refer to a resource, where using the official ID may be inconvenient.<br>The identifier is automatically tokenized from the name/relevant field of the resource if one is not provided. For example, a container named "My Container" will<br>have the identifier of `my-container` and is automatically created by the platform.<br><br>The identifier does not have to be unique. |
| `MDynamic` | `bool?` | Optional | Setting to true enables variable and other advanced logic support on this Pipeline. This is a one-way toggle. Once set to true, it cannot be set back to false. |
| `Stages` | [`List<PipelineStage>`](../../doc/models/pipeline-stage.md) | Optional | An array of stages. |
| `Disable` | `bool?` | Optional | A boolean where true signifies the Pipeline is disabled. |

## Example (as JSON)

```json
{
  "name": "name4",
  "identifier": "identifier2",
  "dynamic": false,
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
    },
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
  ],
  "disable": false
}
```

