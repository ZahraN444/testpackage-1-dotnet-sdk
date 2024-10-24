
# V1 Dns Zones Response

## Structure

`V1DnsZonesResponse`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Data` | [`List<DNSZone>`](../../doc/models/dns-zone.md) | Required | - |
| `Includes` | [`ZoneIncludes`](../../doc/models/zone-includes.md) | Optional | All includable resources linkable to the given Zone. |

## Example (as JSON)

```json
{
  "data": [
    {
      "id": "651586fca6078e98982dbd90",
      "hub_id": "651586fca6078e98982dbd90",
      "creator": {
        "id": "651586fca6078e98982dbd90",
        "type": "employee"
      },
      "origin": "origin4",
      "hosted": false,
      "state": {
        "current": "verifying",
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
        "last_verification": "01/30/2021 08:30:00",
        "verified": "01/30/2021 08:30:00"
      }
    }
  ],
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
    }
  }
}
```

