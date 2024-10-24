
# V1 Infrastructure Ips Pools Response 1

## Structure

`V1InfrastructureIpsPoolsResponse1`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Data` | [`InfrastructureIPPool`](../../doc/models/infrastructure-ip-pool.md) | Required | An IP Pool |
| `Includes` | [`PoolIncludes`](../../doc/models/pool-includes.md) | Optional | Resources associated with an IP Pool. |

## Example (as JSON)

```json
{
  "data": {
    "id": "651586fca6078e98982dbd90",
    "hub_id": "651586fca6078e98982dbd90",
    "server_id": "server_id0",
    "location_id": "location_id4",
    "kind": "ipv4",
    "provider": {
      "vendor": "vendor4",
      "integration_id": "651586fca6078e98982dbd90",
      "location": "location2",
      "reservation": "reservation2",
      "server": "server2",
      "server_assignment": "server_assignment4"
    },
    "floating": false,
    "ips": {
      "total": 178,
      "available": 124
    },
    "block": {
      "cidr": "cidr2",
      "gateway": "gateway2",
      "netmask": "netmask2",
      "network": "network8"
    },
    "state": {
      "current": "released",
      "changed": "01/30/2021 08:30:00",
      "error": {
        "message": "message4",
        "time": "2016-03-13T12:52:32.123Z"
      }
    }
  },
  "includes": {
    "creators": {
      "accounts": {
        "key0": {
          "name": {
            "first": "first6",
            "last": "last0"
          },
          "email": {
            "address": "address2",
            "verified": false,
            "added": "2016-03-13T12:52:32.123Z"
          },
          "id": "id0",
          "events": {
            "last_login": "2016-03-13T12:52:32.123Z"
          }
        }
      },
      "employees": {
        "key0": {
          "name": {
            "first": "first6",
            "last": "last0"
          },
          "email": {
            "address": "address2",
            "verified": false,
            "added": "2016-03-13T12:52:32.123Z"
          },
          "id": "id4",
          "events": {
            "last_login": "2016-03-13T12:52:32.123Z"
          }
        },
        "key1": {
          "name": {
            "first": "first6",
            "last": "last0"
          },
          "email": {
            "address": "address2",
            "verified": false,
            "added": "2016-03-13T12:52:32.123Z"
          },
          "id": "id4",
          "events": {
            "last_login": "2016-03-13T12:52:32.123Z"
          }
        }
      },
      "visitors": {
        "key0": {
          "name": {
            "first": "first6",
            "last": "last0"
          },
          "email": {
            "address": "address2",
            "verified": false,
            "added": "2016-03-13T12:52:32.123Z"
          },
          "id": "id8",
          "events": {
            "last_login": "2016-03-13T12:52:32.123Z"
          }
        }
      },
      "environments": {
        "key0": {
          "id": "id2",
          "identifier": "identifier0",
          "name": "name2",
          "cluster": "cluster8",
          "about": {
            "description": "description4",
            "favorite": false
          },
          "creator": {
            "id": "id8",
            "type": "employee"
          },
          "hub_id": "hub_id4",
          "state": {
            "current": "cloning",
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
          "features": {
            "legacy_networking": false
          },
          "services": {
            "loadbalancer": {
              "enable": false,
              "container_id": "container_id2",
              "high_availability": false,
              "auto_update": false,
              "config": {
                "type": "v1",
                "ipv4": false,
                "ipv6": false,
                "details": {
                  "controllers": [
                    {
                      "default": false,
                      "identifier": "identifier0",
                      "transport": {
                        "disable": false,
                        "mode": "tcp",
                        "config": {
                          "performance": false,
                          "ingress": {
                            "port": 242,
                            "tls": {
                              "enable": false
                            }
                          },
                          "timeouts": {
                            "idle": "idle8"
                          },
                          "verbosity": "low",
                          "extension": {
                            "type": "type2",
                            "details": {
                              "connections": {
                                "key0": {
                                  "key1": "val1",
                                  "key2": "val2"
                                },
                                "key1": {
                                  "key1": "val1",
                                  "key2": "val2"
                                },
                                "key2": {
                                  "key1": "val1",
                                  "key2": "val2"
                                }
                              }
                            }
                          }
                        },
                        "routers": [
                          {
                            "match": {
                              "domains": [
                                "domains0",
                                "domains1",
                                "domains2"
                              ],
                              "internal_port": [
                                223,
                                224,
                                225
                              ],
                              "path": "path4"
                            },
                            "mode": "random",
                            "config": {
                              "sticky_sessions": false,
                              "destination_retries": 166,
                              "tls": {
                                "server_name": "server_name2",
                                "allow_insecure": false,
                                "client_cert_auth": "client_cert_auth6",
                                "client_auth": "require"
                              },
                              "timeouts": {
                                "destination_connection": "destination_connection6"
                              },
                              "extension": {
                                "type": "type6",
                                "details": {
                                  "key0": {
                                    "key1": "val1",
                                    "key2": "val2"
                                  },
                                  "key1": {
                                    "key1": "val1",
                                    "key2": "val2"
                                  },
                                  "key2": {
                                    "key1": "val1",
                                    "key2": "val2"
                                  }
                                }
                              }
                            }
                          },
                          {
                            "match": {
                              "domains": [
                                "domains0",
                                "domains1",
                                "domains2"
                              ],
                              "internal_port": [
                                223,
                                224,
                                225
                              ],
                              "path": "path4"
                            },
                            "mode": "random",
                            "config": {
                              "sticky_sessions": false,
                              "destination_retries": 166,
                              "tls": {
                                "server_name": "server_name2",
                                "allow_insecure": false,
                                "client_cert_auth": "client_cert_auth6",
                                "client_auth": "require"
                              },
                              "timeouts": {
                                "destination_connection": "destination_connection6"
                              },
                              "extension": {
                                "type": "type6",
                                "details": {
                                  "key0": {
                                    "key1": "val1",
                                    "key2": "val2"
                                  },
                                  "key1": {
                                    "key1": "val1",
                                    "key2": "val2"
                                  },
                                  "key2": {
                                    "key1": "val1",
                                    "key2": "val2"
                                  }
                                }
                              }
                            }
                          }
                        ]
                      }
                    },
                    {
                      "default": false,
                      "identifier": "identifier0",
                      "transport": {
                        "disable": false,
                        "mode": "tcp",
                        "config": {
                          "performance": false,
                          "ingress": {
                            "port": 242,
                            "tls": {
                              "enable": false
                            }
                          },
                          "timeouts": {
                            "idle": "idle8"
                          },
                          "verbosity": "low",
                          "extension": {
                            "type": "type2",
                            "details": {
                              "connections": {
                                "key0": {
                                  "key1": "val1",
                                  "key2": "val2"
                                },
                                "key1": {
                                  "key1": "val1",
                                  "key2": "val2"
                                },
                                "key2": {
                                  "key1": "val1",
                                  "key2": "val2"
                                }
                              }
                            }
                          }
                        },
                        "routers": [
                          {
                            "match": {
                              "domains": [
                                "domains0",
                                "domains1",
                                "domains2"
                              ],
                              "internal_port": [
                                223,
                                224,
                                225
                              ],
                              "path": "path4"
                            },
                            "mode": "random",
                            "config": {
                              "sticky_sessions": false,
                              "destination_retries": 166,
                              "tls": {
                                "server_name": "server_name2",
                                "allow_insecure": false,
                                "client_cert_auth": "client_cert_auth6",
                                "client_auth": "require"
                              },
                              "timeouts": {
                                "destination_connection": "destination_connection6"
                              },
                              "extension": {
                                "type": "type6",
                                "details": {
                                  "key0": {
                                    "key1": "val1",
                                    "key2": "val2"
                                  },
                                  "key1": {
                                    "key1": "val1",
                                    "key2": "val2"
                                  },
                                  "key2": {
                                    "key1": "val1",
                                    "key2": "val2"
                                  }
                                }
                              }
                            }
                          },
                          {
                            "match": {
                              "domains": [
                                "domains0",
                                "domains1",
                                "domains2"
                              ],
                              "internal_port": [
                                223,
                                224,
                                225
                              ],
                              "path": "path4"
                            },
                            "mode": "random",
                            "config": {
                              "sticky_sessions": false,
                              "destination_retries": 166,
                              "tls": {
                                "server_name": "server_name2",
                                "allow_insecure": false,
                                "client_cert_auth": "client_cert_auth6",
                                "client_auth": "require"
                              },
                              "timeouts": {
                                "destination_connection": "destination_connection6"
                              },
                              "extension": {
                                "type": "type6",
                                "details": {
                                  "key0": {
                                    "key1": "val1",
                                    "key2": "val2"
                                  },
                                  "key1": {
                                    "key1": "val1",
                                    "key2": "val2"
                                  },
                                  "key2": {
                                    "key1": "val1",
                                    "key2": "val2"
                                  }
                                }
                              }
                            }
                          }
                        ]
                      }
                    },
                    {
                      "default": false,
                      "identifier": "identifier0",
                      "transport": {
                        "disable": false,
                        "mode": "tcp",
                        "config": {
                          "performance": false,
                          "ingress": {
                            "port": 242,
                            "tls": {
                              "enable": false
                            }
                          },
                          "timeouts": {
                            "idle": "idle8"
                          },
                          "verbosity": "low",
                          "extension": {
                            "type": "type2",
                            "details": {
                              "connections": {
                                "key0": {
                                  "key1": "val1",
                                  "key2": "val2"
                                },
                                "key1": {
                                  "key1": "val1",
                                  "key2": "val2"
                                },
                                "key2": {
                                  "key1": "val1",
                                  "key2": "val2"
                                }
                              }
                            }
                          }
                        },
                        "routers": [
                          {
                            "match": {
                              "domains": [
                                "domains0",
                                "domains1",
                                "domains2"
                              ],
                              "internal_port": [
                                223,
                                224,
                                225
                              ],
                              "path": "path4"
                            },
                            "mode": "random",
                            "config": {
                              "sticky_sessions": false,
                              "destination_retries": 166,
                              "tls": {
                                "server_name": "server_name2",
                                "allow_insecure": false,
                                "client_cert_auth": "client_cert_auth6",
                                "client_auth": "require"
                              },
                              "timeouts": {
                                "destination_connection": "destination_connection6"
                              },
                              "extension": {
                                "type": "type6",
                                "details": {
                                  "key0": {
                                    "key1": "val1",
                                    "key2": "val2"
                                  },
                                  "key1": {
                                    "key1": "val1",
                                    "key2": "val2"
                                  },
                                  "key2": {
                                    "key1": "val1",
                                    "key2": "val2"
                                  }
                                }
                              }
                            }
                          },
                          {
                            "match": {
                              "domains": [
                                "domains0",
                                "domains1",
                                "domains2"
                              ],
                              "internal_port": [
                                223,
                                224,
                                225
                              ],
                              "path": "path4"
                            },
                            "mode": "random",
                            "config": {
                              "sticky_sessions": false,
                              "destination_retries": 166,
                              "tls": {
                                "server_name": "server_name2",
                                "allow_insecure": false,
                                "client_cert_auth": "client_cert_auth6",
                                "client_auth": "require"
                              },
                              "timeouts": {
                                "destination_connection": "destination_connection6"
                              },
                              "extension": {
                                "type": "type6",
                                "details": {
                                  "key0": {
                                    "key1": "val1",
                                    "key2": "val2"
                                  },
                                  "key1": {
                                    "key1": "val1",
                                    "key2": "val2"
                                  },
                                  "key2": {
                                    "key1": "val1",
                                    "key2": "val2"
                                  }
                                }
                              }
                            }
                          }
                        ]
                      }
                    }
                  ],
                  "controller_template": {
                    "default": false,
                    "identifier": "identifier4",
                    "transport": {
                      "disable": false,
                      "mode": "tcp",
                      "config": {
                        "performance": false,
                        "ingress": {
                          "port": 242,
                          "tls": {
                            "enable": false
                          }
                        },
                        "timeouts": {
                          "idle": "idle8"
                        },
                        "verbosity": "low",
                        "extension": {
                          "type": "type2",
                          "details": {
                            "connections": {
                              "key0": {
                                "key1": "val1",
                                "key2": "val2"
                              },
                              "key1": {
                                "key1": "val1",
                                "key2": "val2"
                              },
                              "key2": {
                                "key1": "val1",
                                "key2": "val2"
                              }
                            }
                          }
                        }
                      },
                      "routers": [
                        {
                          "match": {
                            "domains": [
                              "domains0",
                              "domains1",
                              "domains2"
                            ],
                            "internal_port": [
                              223,
                              224,
                              225
                            ],
                            "path": "path4"
                          },
                          "mode": "random",
                          "config": {
                            "sticky_sessions": false,
                            "destination_retries": 166,
                            "tls": {
                              "server_name": "server_name2",
                              "allow_insecure": false,
                              "client_cert_auth": "client_cert_auth6",
                              "client_auth": "require"
                            },
                            "timeouts": {
                              "destination_connection": "destination_connection6"
                            },
                            "extension": {
                              "type": "type6",
                              "details": {
                                "key0": {
                                  "key1": "val1",
                                  "key2": "val2"
                                },
                                "key1": {
                                  "key1": "val1",
                                  "key2": "val2"
                                },
                                "key2": {
                                  "key1": "val1",
                                  "key2": "val2"
                                }
                              }
                            }
                          }
                        },
                        {
                          "match": {
                            "domains": [
                              "domains0",
                              "domains1",
                              "domains2"
                            ],
                            "internal_port": [
                              223,
                              224,
                              225
                            ],
                            "path": "path4"
                          },
                          "mode": "random",
                          "config": {
                            "sticky_sessions": false,
                            "destination_retries": 166,
                            "tls": {
                              "server_name": "server_name2",
                              "allow_insecure": false,
                              "client_cert_auth": "client_cert_auth6",
                              "client_auth": "require"
                            },
                            "timeouts": {
                              "destination_connection": "destination_connection6"
                            },
                            "extension": {
                              "type": "type6",
                              "details": {
                                "key0": {
                                  "key1": "val1",
                                  "key2": "val2"
                                },
                                "key1": {
                                  "key1": "val1",
                                  "key2": "val2"
                                },
                                "key2": {
                                  "key1": "val1",
                                  "key2": "val2"
                                }
                              }
                            }
                          }
                        }
                      ]
                    }
                  }
                }
              }
            },
            "discovery": {
              "enable": false,
              "container_id": "container_id6",
              "high_availability": false,
              "auto_update": false,
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
              }
            },
            "vpn": {
              "enable": false,
              "container_id": "container_id0",
              "auto_update": false,
              "config": {
                "allow_internet": false,
                "auth": {
                  "webhook": "webhook4",
                  "cycle_accounts": false,
                  "vpn_accounts": false
                }
              }
            },
            "scheduler": {
              "enable": false,
              "container_id": "container_id0",
              "high_availability": false,
              "auto_update": false,
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
              }
            }
          },
          "private_network": {
            "vxlan_tag": 126,
            "subnet": "subnet8",
            "ipv6": {
              "ip": "ip0",
              "cidr": "cidr6"
            },
            "legacy": {
              "subnet": 58,
              "ipv4": {
                "ip": "ip8",
                "cidr": "cidr4"
              }
            }
          },
          "deployments": {
            "tags": {
              "key0": "tags1",
              "key1": "tags2"
            }
          },
          "meta": {
            "containers_count": {
              "state": {
                "key0": 148,
                "key1": 149,
                "key2": 150
              },
              "total": 80,
              "available": 126
            },
            "instances_count": {
              "state": {
                "key0": 136,
                "key1": 135,
                "key2": 134
              },
              "total": 108,
              "available": 154
            },
            "containers": [
              {
                "id": "id2",
                "name": "name2",
                "state": {
                  "current": "deleting",
                  "desired": "stopping",
                  "changed": "2016-03-13T12:52:32.123Z",
                  "error": {
                    "message": "message4",
                    "time": "2016-03-13T12:52:32.123Z"
                  }
                },
                "image": {
                  "id": "id6",
                  "service": "discovery"
                },
                "environment": {
                  "id": "id6",
                  "cluster": "cluster8",
                  "container_subnet": "container_subnet6",
                  "ipv6": {
                    "ip": "ip8",
                    "cidr": "cidr4"
                  },
                  "legacy": {
                    "subnet": 58,
                    "ipv4": {
                      "ip": "ip8",
                      "cidr": "cidr4"
                    }
                  }
                }
              }
            ]
          }
        }
      },
      "api_keys": {
        "key0": {
          "id": "id0",
          "name": "name0",
          "hub_id": "hub_id2",
          "secret": "secret4",
          "permissions": {
            "all_environments": false,
            "environments": [
              {
                "id": "id2",
                "manage": false
              }
            ]
          },
          "capabilities": {
            "all": false,
            "specific": [
              "specific4"
            ]
          },
          "ips": [
            "ips4"
          ],
          "state": {
            "current": "deleted",
            "changed": "2016-03-13T12:52:32.123Z",
            "error": {
              "message": "message4",
              "time": "2016-03-13T12:52:32.123Z"
            }
          },
          "events": {
            "key0": "2016-03-13T12:52:32.123Z",
            "key1": "2016-03-13T12:52:32.123Z"
          }
        }
      }
    },
    "servers": {
      "key0": {
        "id": "id2",
        "hub_id": "hub_id4",
        "location_id": "location_id6",
        "model_id": "model_id2",
        "node_id": "node_id0",
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
        "hostname": "hostname2",
        "creator": {
          "id": "id8",
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
        "cluster": "cluster8",
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
        "autoscale": {
          "group_id": "group_id8"
        },
        "ephemeral": false,
        "evacuate": {
          "started": "2016-03-13T12:52:32.123Z"
        },
        "state": {
          "current": "configuring",
          "changed": "2016-03-13T12:52:32.123Z",
          "error": {
            "message": "message4",
            "time": "2016-03-13T12:52:32.123Z"
          }
        },
        "events": {
          "created": "2016-03-13T12:52:32.123Z",
          "updated": "2016-03-13T12:52:32.123Z",
          "deleted": "2016-03-13T12:52:32.123Z",
          "latest_instance": "2016-03-13T12:52:32.123Z",
          "provisioning": {
            "started": "2016-03-13T12:52:32.123Z",
            "failed": "2016-03-13T12:52:32.123Z",
            "completed": "2016-03-13T12:52:32.123Z"
          }
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
      },
      "key1": {
        "id": "id2",
        "hub_id": "hub_id4",
        "location_id": "location_id6",
        "model_id": "model_id2",
        "node_id": "node_id0",
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
        "hostname": "hostname2",
        "creator": {
          "id": "id8",
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
        "cluster": "cluster8",
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
        "autoscale": {
          "group_id": "group_id8"
        },
        "ephemeral": false,
        "evacuate": {
          "started": "2016-03-13T12:52:32.123Z"
        },
        "state": {
          "current": "configuring",
          "changed": "2016-03-13T12:52:32.123Z",
          "error": {
            "message": "message4",
            "time": "2016-03-13T12:52:32.123Z"
          }
        },
        "events": {
          "created": "2016-03-13T12:52:32.123Z",
          "updated": "2016-03-13T12:52:32.123Z",
          "deleted": "2016-03-13T12:52:32.123Z",
          "latest_instance": "2016-03-13T12:52:32.123Z",
          "provisioning": {
            "started": "2016-03-13T12:52:32.123Z",
            "failed": "2016-03-13T12:52:32.123Z",
            "completed": "2016-03-13T12:52:32.123Z"
          }
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
      },
      "key2": {
        "id": "id2",
        "hub_id": "hub_id4",
        "location_id": "location_id6",
        "model_id": "model_id2",
        "node_id": "node_id0",
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
        "hostname": "hostname2",
        "creator": {
          "id": "id8",
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
        "cluster": "cluster8",
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
        "autoscale": {
          "group_id": "group_id8"
        },
        "ephemeral": false,
        "evacuate": {
          "started": "2016-03-13T12:52:32.123Z"
        },
        "state": {
          "current": "configuring",
          "changed": "2016-03-13T12:52:32.123Z",
          "error": {
            "message": "message4",
            "time": "2016-03-13T12:52:32.123Z"
          }
        },
        "events": {
          "created": "2016-03-13T12:52:32.123Z",
          "updated": "2016-03-13T12:52:32.123Z",
          "deleted": "2016-03-13T12:52:32.123Z",
          "latest_instance": "2016-03-13T12:52:32.123Z",
          "provisioning": {
            "started": "2016-03-13T12:52:32.123Z",
            "failed": "2016-03-13T12:52:32.123Z",
            "completed": "2016-03-13T12:52:32.123Z"
          }
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
    },
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
    }
  }
}
```

