
# V1 Containers Servers Usable Response

## Structure

`V1ContainersServersUsableResponse`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Data` | [`List<Server>`](../../doc/models/server.md) | Required | - |
| `Includes` | [`ServerIncludes`](../../doc/models/server-includes.md) | Optional | A resource associated with a server. |

## Example (as JSON)

```json
{
  "data": [
    {
      "id": "651586fca6078e98982dbd90",
      "hub_id": "651586fca6078e98982dbd90",
      "location_id": "location_id4",
      "model_id": "model_id0",
      "node_id": "node_id8",
      "shared_file_systems": {
        "mounts": {
          "key0": {
            "type": "type8",
            "options": "options0",
            "source": "source2"
          },
          "key1": {
            "type": "type8",
            "options": "options0",
            "source": "source2"
          }
        },
        "directories": {
          "key0": {
            "key1": "val1",
            "key2": "val2"
          }
        }
      },
      "hostname": "hostname6",
      "creator": {
        "id": "651586fca6078e98982dbd90",
        "type": "employee"
      },
      "provider": {
        "vendor": "vendor4",
        "model": "model6",
        "location": "location2",
        "server": "server2",
        "init_ips": [
          "init_ips3",
          "init_ips2"
        ],
        "mac_addr": "mac_addr2",
        "extra": {
          "key1": "val1",
          "key2": "val2"
        },
        "provision_options": {
          "attachesd_storage_size": 103.2,
          "reservation_id": "reservation_id8"
        }
      },
      "cluster": "cluster6",
      "features": {
        "sftp": false,
        "base_volume_gb": 224
      },
      "constraints": {
        "tags": [
          "tags3",
          "tags4",
          "tags5"
        ],
        "allow": {
          "pool": false,
          "services": false,
          "overcommit": false
        }
      },
      "ephemeral": false,
      "state": {
        "current": "configuring",
        "changed": "01/30/2021 08:30:00",
        "error": {
          "message": "message4",
          "time": "2016-03-13T12:52:32.123Z"
        }
      },
      "events": {
        "created": "01/30/2021 08:30:00",
        "updated": "01/30/2021 08:30:00",
        "deleted": "01/30/2021 08:30:00",
        "latest_instance": "01/30/2021 08:30:00",
        "provisioning": {
          "started": "01/30/2021 08:30:00",
          "failed": "01/30/2021 08:30:00",
          "completed": "01/30/2021 08:30:00"
        }
      },
      "autoscale": {
        "group_id": "group_id8"
      },
      "evacuate": {
        "started": "2016-03-13T12:52:32.123Z"
      },
      "meta": {
        "node": {
          "last_checkin": "2016-03-13T12:52:32.123Z",
          "drivers": [
            "drivers4",
            "drivers5"
          ],
          "state": {
            "current": "authorizing",
            "changed": "2016-03-13T12:52:32.123Z",
            "error": {
              "message": "message4",
              "time": "2016-03-13T12:52:32.123Z"
            }
          },
          "stats": {
            "network": {
              "interfaces": {
                "key0": {
                  "interface": "interface8",
                  "flags": "flags6",
                  "mtu": 38,
                  "mac_addr": "mac_addr8",
                  "addrs": [
                    "addrs9",
                    "addrs0"
                  ]
                }
              },
              "external_ipv4": "external_ipv46",
              "external_ipv6": "external_ipv62"
            },
            "uptime": {
              "seconds": 205.14,
              "cpu_idle": 38.8
            },
            "cpu": {
              "cores": 8,
              "processors": [
                {
                  "model": "model2",
                  "speed": 12.92
                },
                {
                  "model": "model2",
                  "speed": 12.92
                }
              ],
              "usage": {
                "user": 2,
                "nice": 30,
                "system": 206,
                "idle": 254,
                "iowait": 180
              }
            },
            "load": {
              "avg1m": 164.12,
              "avg5m": 123.4,
              "avg15m": 158.96
            },
            "ram": {
              "available": 172,
              "free": 224,
              "total": 126
            },
            "storage": {
              "volume_groups": {
                "key0": {
                  "name": "name8",
                  "size": 104,
                  "volumes": {
                    "key0": {
                      "name": "name6",
                      "size": 224,
                      "data_percent": 206,
                      "meta_percent": 96,
                      "pool": "pool0"
                    },
                    "key1": {
                      "name": "name6",
                      "size": 224,
                      "data_percent": 206,
                      "meta_percent": 96,
                      "pool": "pool0"
                    },
                    "key2": {
                      "name": "name6",
                      "size": 224,
                      "data_percent": 206,
                      "meta_percent": 96,
                      "pool": "pool0"
                    }
                  }
                },
                "key1": {
                  "name": "name8",
                  "size": 104,
                  "volumes": {
                    "key0": {
                      "name": "name6",
                      "size": 224,
                      "data_percent": 206,
                      "meta_percent": 96,
                      "pool": "pool0"
                    },
                    "key1": {
                      "name": "name6",
                      "size": 224,
                      "data_percent": 206,
                      "meta_percent": 96,
                      "pool": "pool0"
                    },
                    "key2": {
                      "name": "name6",
                      "size": 224,
                      "data_percent": 206,
                      "meta_percent": 96,
                      "pool": "pool0"
                    }
                  }
                }
              },
              "mounts": {
                "key0": {
                  "device": "device8",
                  "type": "type8",
                  "mountpoint": "mountpoint8",
                  "total": 26,
                  "free": 68,
                  "used": 220
                },
                "key1": {
                  "device": "device8",
                  "type": "type8",
                  "mountpoint": "mountpoint8",
                  "total": 26,
                  "free": 68,
                  "used": 220
                }
              }
            },
            "os": {
              "release": "release0",
              "kernel": "kernel2",
              "hostname": "hostname6"
            },
            "versions": {
              "services": {
                "key0": "services0",
                "key1": "services1",
                "key2": "services2"
              }
            }
          },
          "healthy": false,
          "online": false
        },
        "instances_count": {
          "state": {
            "key0": 136,
            "key1": 135,
            "key2": 134
          },
          "total": 108,
          "available": 154
        }
      }
    }
  ],
  "includes": {
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
      },
      "key1": {
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
      },
      "key1": {
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
      },
      "key2": {
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
      }
    }
  }
}
```

