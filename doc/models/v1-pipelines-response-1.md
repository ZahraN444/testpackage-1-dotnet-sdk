
# V1 Pipelines Response 1

## Structure

`V1PipelinesResponse1`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Data` | [`Pipeline`](../../doc/models/pipeline.md) | Required | A pipeline resource. |

## Example (as JSON)

```json
{
  "data": {
    "id": "651586fca6078e98982dbd90",
    "name": "name0",
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
    "identifier": "identifier8",
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
    ]
  }
}
```

