
# V1 Pipelines Request 1

## Structure

`V1PipelinesRequest1`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Name` | `string` | Optional | A name for the Pipeline. |
| `MDynamic` | `bool?` | Optional | Setting to true enables variable and other advanced logic support on this Pipeline. This is a one-way toggle. Once set to true, it cannot be set back to false. |
| `Stages` | [`List<PipelineStage>`](../../doc/models/pipeline-stage.md) | Optional | An array of stages. |
| `Disable` | `bool?` | Optional | A boolean where true signifies the Pipeline is disabled. |

## Example (as JSON)

```json
{
  "name": "name2",
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

