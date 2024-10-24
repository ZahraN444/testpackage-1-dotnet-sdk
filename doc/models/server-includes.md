
# Server Includes

A resource associated with a server.

## Structure

`ServerIncludes`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Locations` | [`Dictionary<string, ProviderLocation>`](../../doc/models/provider-location.md) | Optional | A resource thats associated with a provider location. |
| `Models` | [`Dictionary<string, ProviderServerModel>`](../../doc/models/provider-server-model.md) | Optional | A resources that assocaited with a provider server. |
| `Integrations` | [`Dictionary<string, Integration>`](../../doc/models/integration.md) | Optional | A resource thats associated with an integration. |

## Example (as JSON)

```json
{
  "locations": {
    "key0": {
      "id": "id8",
      "name": "name8",
      "geographic": {
        "latitude": 10,
        "longitude": 46,
        "city": "city4",
        "state": "state0",
        "country": "country8",
        "region": "region0"
      },
      "provider": {
        "identifier": "identifier4",
        "integration_id": "integration_id0",
        "location": "location2",
        "code": "code6",
        "availability_zones": [
          "availability_zones5",
          "availability_zones6"
        ]
      },
      "compatible": false,
      "features": {
        "available": [
          "available2",
          "available3"
        ],
        "supported": [
          "supported2",
          "supported3",
          "supported4"
        ]
      },
      "abbreviation": "abbreviation0",
      "annotations": {
        "key0": {
          "key1": "val1",
          "key2": "val2"
        },
        "key1": {
          "key1": "val1",
          "key2": "val2"
        }
      }
    }
  },
  "models": {
    "key0": {
      "id": "id4",
      "name": "name4",
      "description": "description4",
      "specs": {
        "cpu": {
          "count": 118,
          "cores": 8,
          "threads": 196,
          "type": "type6",
          "shared": false,
          "extra": {
            "key0": "extra8",
            "key1": "extra7"
          }
        },
        "gpu": {
          "count": 80,
          "cores": 66,
          "vram_gb": 46,
          "type": "type8",
          "shared": false,
          "extra": {
            "key0": "extra4",
            "key1": "extra3"
          }
        },
        "memory": {
          "size_gb": 146,
          "type": "type0",
          "extra": {
            "key0": "extra4"
          }
        },
        "storage": [
          {
            "count": 246,
            "size_gb": 62,
            "type": "type2",
            "extra": {
              "key0": "extra0",
              "key1": "extra1",
              "key2": "extra2"
            }
          },
          {
            "count": 246,
            "size_gb": 62,
            "type": "type2",
            "extra": {
              "key0": "extra0",
              "key1": "extra1",
              "key2": "extra2"
            }
          }
        ],
        "network": [
          {
            "count": 94,
            "scope": "public",
            "throughput": 184,
            "type": "type6"
          },
          {
            "count": 94,
            "scope": "public",
            "throughput": 184,
            "type": "type6"
          },
          {
            "count": 94,
            "scope": "public",
            "throughput": 184,
            "type": "type6"
          }
        ],
        "features": {
          "raid": "raid2",
          "aws": {
            "ena_support": false,
            "ebs_optimized": false
          }
        }
      },
      "provider": {
        "identifier": "identifier4",
        "integration_id": "String1",
        "category": "category6",
        "class": "class4",
        "model": "model6",
        "locations": [
          "locations6",
          "locations7",
          "locations8"
        ],
        "availability_zones": {
          "key0": {
            "key1": "val1",
            "key2": "val2"
          },
          "key1": {
            "key1": "val1",
            "key2": "val2"
          }
        }
      },
      "price": {
        "mills": 210,
        "term": "monthly"
      },
      "compatible": false,
      "low_resource": false,
      "location_ids": [
        "location_ids4",
        "location_ids5"
      ]
    }
  },
  "integrations": {
    "key0": {
      "id": "id6",
      "name": "name6",
      "vendor": "vendor2",
      "identifier": "identifier6",
      "auth": {
        "region": "region2",
        "namespace": "namespace6",
        "api_key": "api_key6",
        "key_id": "key_id2",
        "secret": "secret8"
      },
      "extra": {
        "key0": "extra8"
      },
      "creator": {
        "id": "id8",
        "type": "employee"
      },
      "hub_id": "hub_id8",
      "state": {
        "current": "live",
        "changed": "2016-03-13T12:52:32.123Z",
        "error": {
          "message": "message4",
          "time": "2016-03-13T12:52:32.123Z"
        }
      },
      "events": {
        "created": "2016-03-13T12:52:32.123Z",
        "updated": "2016-03-13T12:52:32.123Z",
        "deleted": "2016-03-13T12:52:32.123Z"
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
    },
    "key1": {
      "id": "id6",
      "name": "name6",
      "vendor": "vendor2",
      "identifier": "identifier6",
      "auth": {
        "region": "region2",
        "namespace": "namespace6",
        "api_key": "api_key6",
        "key_id": "key_id2",
        "secret": "secret8"
      },
      "extra": {
        "key0": "extra8"
      },
      "creator": {
        "id": "id8",
        "type": "employee"
      },
      "hub_id": "hub_id8",
      "state": {
        "current": "live",
        "changed": "2016-03-13T12:52:32.123Z",
        "error": {
          "message": "message4",
          "time": "2016-03-13T12:52:32.123Z"
        }
      },
      "events": {
        "created": "2016-03-13T12:52:32.123Z",
        "updated": "2016-03-13T12:52:32.123Z",
        "deleted": "2016-03-13T12:52:32.123Z"
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
  }
}
```

