
# V1 Hubs Current Activity Response

## Structure

`V1HubsCurrentActivityResponse`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Data` | [`List<Activity>`](../../doc/models/activity.md) | Required | - |
| `Includes` | [`ActivityIncludes`](../../doc/models/activity-includes.md) | Optional | All includable resources linkable to the given records. |

## Example (as JSON)

```json
{
  "data": [
    {
      "id": "651586fca6078e98982dbd90",
      "hub_id": "651586fca6078e98982dbd90",
      "user": {
        "type": "platform",
        "id": "id0"
      },
      "verbosity": 14,
      "context": {
        "environment_id": "environment_id0",
        "container_id": "container_id8",
        "instance_id": "instance_id8",
        "server_id": "server_id8",
        "stack_id": "stack_id2"
      },
      "session": {
        "url": "url2",
        "ip": "ip2",
        "token": {
          "application_id": "651586fca6078e98982dbd90",
          "application_capabilities_version": 8
        },
        "api_key": "api_key4"
      },
      "changes": [
        {
          "component": "component6",
          "before": {
            "id": "id0",
            "number": 192,
            "string": "string4"
          },
          "after": {
            "id": "id2",
            "number": 216,
            "string": "string6"
          }
        }
      ],
      "annotations": {
        "key0": {
          "key1": "val1",
          "key2": "val2"
        },
        "key1": {
          "key1": "val1",
          "key2": "val2"
        }
      },
      "error": {
        "message": "message4"
      },
      "component": {
        "id": "651586fca6078e98982dbd90",
        "type": "type2"
      },
      "status": "request",
      "event": "container.instance.task.migrate_revert",
      "time": "01/30/2021 08:30:00",
      "tags": [
        "tags5",
        "tags6",
        "tags7"
      ],
      "security": {
        "risk": "medium",
        "surface": "network",
        "event": "notice",
        "attack": "access-elevation"
      },
      "monitor": {
        "level": "info",
        "event": "reaction",
        "state": "none"
      }
    }
  ],
  "includes": {
    "users": {
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
    "components": {
      "key0": {
        "id": "id6",
        "identifier": "identifier4",
        "name": "name6",
        "creator": {
          "id": "id8",
          "type": "employee"
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
        },
        "hub_id": "hub_id8",
        "image": {
          "id": "String7",
          "extension": {
            "identifier": "identifier6"
          },
          "service": "scheduler"
        },
        "stack": {
          "id": "id0",
          "build_id": "build_id0",
          "identifier": "identifier2"
        },
        "config": {
          "network": {
            "public": "disable",
            "hostname": "hostname0",
            "ports": [
              "ports9",
              "ports0"
            ]
          },
          "deploy": {
            "instances": 208,
            "strategy": "high-availability",
            "stateful": {
              "options": {
                "use_base_hostname": false
              }
            },
            "constraints": {
              "node": {
                "tags": {
                  "any": [
                    "any6",
                    "any7"
                  ],
                  "all": [
                    "all9"
                  ]
                }
              },
              "secrets": [
                "secrets1",
                "secrets2"
              ]
            },
            "shutdown": {
              "graceful_timeout": "String7",
              "signals": [
                "SIGHUP",
                "SIGQUIT"
              ]
            },
            "startup": {
              "delay": "delay2"
            }
          },
          "scale": {
            "autoscale_group": "autoscale_group0",
            "instances": {
              "delta": 232,
              "max": 128,
              "max_server": 132,
              "min_ttl": "min_ttl4"
            },
            "window": "window4",
            "thresholds": [
              {
                "type": "ram",
                "details": {
                  "used": "used2"
                }
              },
              {
                "type": "ram",
                "details": {
                  "used": "used2"
                }
              }
            ]
          },
          "runtime": {
            "command": {
              "path": "path0",
              "args": "args6"
            },
            "namespaces": [
              "uts"
            ],
            "environment_vars": {
              "key0": "environment_vars8",
              "key1": "environment_vars7"
            },
            "privileged": false,
            "capabilities": [
              "CAP_WAKE_ALARM"
            ],
            "workdir": "workdir6"
          },
          "resources": {
            "cpu": {
              "shares": {
                "limit": 214,
                "reserve": 14
              },
              "cpus": "cpus2"
            },
            "ram": {
              "limit": "limit4",
              "reserve": "reserve0"
            }
          },
          "integrations": {
            "webhooks": {
              "events": {
                "deploy": "deploy2",
                "start": "start4",
                "stop": "stop2"
              },
              "config": "config2"
            },
            "files": [
              {
                "source": "source0",
                "destination": "destination0"
              },
              {
                "source": "source0",
                "destination": "destination0"
              }
            ],
            "lets_encrypt": {
              "enable": false,
              "certificate_path": "certificate_path4",
              "chain_path": "chain_path2",
              "key_path": "key_path0",
              "bundle_path": "bundle_path6",
              "additional_certs_path": "additional_certs_path4"
            },
            "backups": {
              "integration_id": "integration_id6",
              "backup": {
                "command": "command4",
                "timeout": "String9",
                "cron_string": "cron_string6"
              },
              "restore": {
                "command": "command8",
                "timeout": "timeout4"
              },
              "retention": "String7"
            },
            "shared_file_systems": {
              "key0": {
                "writable": false,
                "mount_point": "mount_point0"
              },
              "key1": {
                "writable": false,
                "mount_point": "mount_point0"
              },
              "key2": {
                "writable": false,
                "mount_point": "mount_point0"
              }
            }
          }
        },
        "deployment": {
          "version": "version0"
        },
        "instances": 250,
        "volumes": [
          {
            "id": "id6",
            "hash": "hash2",
            "config": {
              "read_only": false,
              "local": {
                "max_size": "max_size6",
                "storage_pool": false
              },
              "destination": "destination8",
              "remote_access": {
                "enable": false,
                "ips": [
                  "ips4",
                  "ips5",
                  "ips6"
                ],
                "web_hook": "web_hook0",
                "password": {
                  "algorithm": "sha512",
                  "data": "data4"
                }
              }
            }
          }
        ],
        "annotations": {
          "key0": {
            "key1": "val1",
            "key2": "val2"
          },
          "key1": {
            "key1": "val1",
            "key2": "val2"
          }
        },
        "role": "orchestrator",
        "stateful": false,
        "deprecate": false,
        "lock": false,
        "state": {
          "current": "deleting",
          "desired": "stopping",
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
          "started": "2016-03-13T12:52:32.123Z"
        }
      },
      "key1": {
        "id": "id6",
        "identifier": "identifier4",
        "name": "name6",
        "creator": {
          "id": "id8",
          "type": "employee"
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
        },
        "hub_id": "hub_id8",
        "image": {
          "id": "String7",
          "extension": {
            "identifier": "identifier6"
          },
          "service": "scheduler"
        },
        "stack": {
          "id": "id0",
          "build_id": "build_id0",
          "identifier": "identifier2"
        },
        "config": {
          "network": {
            "public": "disable",
            "hostname": "hostname0",
            "ports": [
              "ports9",
              "ports0"
            ]
          },
          "deploy": {
            "instances": 208,
            "strategy": "high-availability",
            "stateful": {
              "options": {
                "use_base_hostname": false
              }
            },
            "constraints": {
              "node": {
                "tags": {
                  "any": [
                    "any6",
                    "any7"
                  ],
                  "all": [
                    "all9"
                  ]
                }
              },
              "secrets": [
                "secrets1",
                "secrets2"
              ]
            },
            "shutdown": {
              "graceful_timeout": "String7",
              "signals": [
                "SIGHUP",
                "SIGQUIT"
              ]
            },
            "startup": {
              "delay": "delay2"
            }
          },
          "scale": {
            "autoscale_group": "autoscale_group0",
            "instances": {
              "delta": 232,
              "max": 128,
              "max_server": 132,
              "min_ttl": "min_ttl4"
            },
            "window": "window4",
            "thresholds": [
              {
                "type": "ram",
                "details": {
                  "used": "used2"
                }
              },
              {
                "type": "ram",
                "details": {
                  "used": "used2"
                }
              }
            ]
          },
          "runtime": {
            "command": {
              "path": "path0",
              "args": "args6"
            },
            "namespaces": [
              "uts"
            ],
            "environment_vars": {
              "key0": "environment_vars8",
              "key1": "environment_vars7"
            },
            "privileged": false,
            "capabilities": [
              "CAP_WAKE_ALARM"
            ],
            "workdir": "workdir6"
          },
          "resources": {
            "cpu": {
              "shares": {
                "limit": 214,
                "reserve": 14
              },
              "cpus": "cpus2"
            },
            "ram": {
              "limit": "limit4",
              "reserve": "reserve0"
            }
          },
          "integrations": {
            "webhooks": {
              "events": {
                "deploy": "deploy2",
                "start": "start4",
                "stop": "stop2"
              },
              "config": "config2"
            },
            "files": [
              {
                "source": "source0",
                "destination": "destination0"
              },
              {
                "source": "source0",
                "destination": "destination0"
              }
            ],
            "lets_encrypt": {
              "enable": false,
              "certificate_path": "certificate_path4",
              "chain_path": "chain_path2",
              "key_path": "key_path0",
              "bundle_path": "bundle_path6",
              "additional_certs_path": "additional_certs_path4"
            },
            "backups": {
              "integration_id": "integration_id6",
              "backup": {
                "command": "command4",
                "timeout": "String9",
                "cron_string": "cron_string6"
              },
              "restore": {
                "command": "command8",
                "timeout": "timeout4"
              },
              "retention": "String7"
            },
            "shared_file_systems": {
              "key0": {
                "writable": false,
                "mount_point": "mount_point0"
              },
              "key1": {
                "writable": false,
                "mount_point": "mount_point0"
              },
              "key2": {
                "writable": false,
                "mount_point": "mount_point0"
              }
            }
          }
        },
        "deployment": {
          "version": "version0"
        },
        "instances": 250,
        "volumes": [
          {
            "id": "id6",
            "hash": "hash2",
            "config": {
              "read_only": false,
              "local": {
                "max_size": "max_size6",
                "storage_pool": false
              },
              "destination": "destination8",
              "remote_access": {
                "enable": false,
                "ips": [
                  "ips4",
                  "ips5",
                  "ips6"
                ],
                "web_hook": "web_hook0",
                "password": {
                  "algorithm": "sha512",
                  "data": "data4"
                }
              }
            }
          }
        ],
        "annotations": {
          "key0": {
            "key1": "val1",
            "key2": "val2"
          },
          "key1": {
            "key1": "val1",
            "key2": "val2"
          }
        },
        "role": "orchestrator",
        "stateful": false,
        "deprecate": false,
        "lock": false,
        "state": {
          "current": "deleting",
          "desired": "stopping",
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
          "started": "2016-03-13T12:52:32.123Z"
        }
      }
    }
  }
}
```

