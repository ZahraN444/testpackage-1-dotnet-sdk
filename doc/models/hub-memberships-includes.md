
# Hub Memberships Includes

A resource thats associated with a hub membershp.

## Structure

`HubMembershipsIncludes`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Senders` | [`Senders`](../../doc/models/senders.md) | Optional | A record with an ID mapped to a public account for the account that sent this memberships initial invite. |
| `Accounts` | [`Dictionary<string, PublicAccount>`](../../doc/models/public-account.md) | Optional | A record with an ID mapped to a public account. |
| `Hubs` | [`Dictionary<string, Hub>`](../../doc/models/hub.md) | Optional | A record with an ID mapped to a hub resource. |
| `Roles` | [`Dictionary<string, Role>`](../../doc/models/role.md) | Optional | A map of Roles relevant to this Hub Membership, keyed by the Role ID. |
| `RolesIdentifiers` | `Dictionary<string, string>` | Optional | A map of Roles relevant to this Hub Membership, keyed by the Role ID. |

## Example (as JSON)

```json
{
  "senders": {
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
        "id": "id0",
        "events": {
          "last_login": "2016-03-13T12:52:32.123Z"
        }
      }
    }
  },
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
      "id": "id0",
      "events": {
        "last_login": "2016-03-13T12:52:32.123Z"
      }
    },
    "key2": {
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
  "hubs": {
    "key0": {
      "id": "id8",
      "identifier": "identifier4",
      "name": "name8",
      "creator": {
        "id": "id8",
        "type": "employee"
      },
      "events": {
        "created": "2016-03-13T12:52:32.123Z",
        "updated": "2016-03-13T12:52:32.123Z",
        "deleted": "2016-03-13T12:52:32.123Z",
        "converted": "2016-03-13T12:52:32.123Z",
        "first_order": "2016-03-13T12:52:32.123Z",
        "first_provider": "2016-03-13T12:52:32.123Z",
        "first_server": "2016-03-13T12:52:32.123Z",
        "first_environment": "2016-03-13T12:52:32.123Z"
      },
      "state": {
        "current": "live",
        "changed": "2016-03-13T12:52:32.123Z",
        "error": {
          "message": "message4",
          "time": "2016-03-13T12:52:32.123Z"
        }
      },
      "webhooks": {
        "server_deployed": "server_deployed2",
        "server_deleted": "server_deleted0"
      },
      "billing": {
        "term": {
          "start": "2016-03-13T12:52:32.123Z",
          "end": "2016-03-13T12:52:32.123Z",
          "renew": "once"
        },
        "allow_prepaid": false,
        "pause_invoices": false,
        "disable": false,
        "plans": {
          "tier_id": "tier_id2",
          "support_id": "support_id6"
        },
        "emails": [
          "emails7"
        ]
      },
      "meta": {
        "membership": {
          "id": "id4",
          "account_id": "account_id6",
          "hub_id": "hub_id6",
          "events": {
            "created": "2016-03-13T12:52:32.123Z",
            "updated": "2016-03-13T12:52:32.123Z",
            "deleted": "2016-03-13T12:52:32.123Z",
            "joined": "2016-03-13T12:52:32.123Z"
          },
          "role_id": "role_id0",
          "permissions": {
            "all_environments": false,
            "environments": [
              {
                "id": "id2",
                "manage": false
              }
            ]
          },
          "preferences": {
            "portal": {
              "notifications": {
                "jobs": {
                  "apikey_alerts": false
                }
              }
            },
            "email": {
              "notificaitons": {
                "server": {
                  "new": false,
                  "offline": false
                }
              }
            }
          },
          "state": {
            "current": "declined",
            "changed": "2016-03-13T12:52:32.123Z",
            "error": {
              "message": "message4",
              "time": "2016-03-13T12:52:32.123Z"
            }
          },
          "invitation": {
            "sender": {
              "id": "id8",
              "type": "type2"
            },
            "recipient": "recipient2",
            "events": {
              "created": "2016-03-13T12:52:32.123Z",
              "updated": "2016-03-13T12:52:32.123Z",
              "deleted": "2016-03-13T12:52:32.123Z",
              "accepted": "2016-03-13T12:52:32.123Z",
              "declined": "2016-03-13T12:52:32.123Z",
              "revoked": "2016-03-13T12:52:32.123Z"
            }
          },
          "cycle": {
            "employee_id": "employee_id0"
          },
          "meta": {
            "capabilities": {
              "all": false,
              "specific": [
                "pipelines-view"
              ]
            }
          }
        }
      }
    }
  },
  "roles": {
    "key0": {
      "id": "id2",
      "name": "name2",
      "root": false,
      "default": "String3",
      "rank": 70,
      "identifier": "identifier0",
      "creator": {
        "id": "id8",
        "type": "employee"
      },
      "capabilities": {
        "all": false,
        "specific": [
          "pipelines-view"
        ]
      },
      "extra": {
        "key0": "extra2",
        "key1": "extra1",
        "key2": "extra0"
      },
      "hub_id": "hub_id4",
      "state": {
        "current": "current2",
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
      }
    },
    "key1": {
      "id": "id2",
      "name": "name2",
      "root": false,
      "default": "String3",
      "rank": 70,
      "identifier": "identifier0",
      "creator": {
        "id": "id8",
        "type": "employee"
      },
      "capabilities": {
        "all": false,
        "specific": [
          "pipelines-view"
        ]
      },
      "extra": {
        "key0": "extra2",
        "key1": "extra1",
        "key2": "extra0"
      },
      "hub_id": "hub_id4",
      "state": {
        "current": "current2",
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
      }
    },
    "key2": {
      "id": "id2",
      "name": "name2",
      "root": false,
      "default": "String3",
      "rank": 70,
      "identifier": "identifier0",
      "creator": {
        "id": "id8",
        "type": "employee"
      },
      "capabilities": {
        "all": false,
        "specific": [
          "pipelines-view"
        ]
      },
      "extra": {
        "key0": "extra2",
        "key1": "extra1",
        "key2": "extra0"
      },
      "hub_id": "hub_id4",
      "state": {
        "current": "current2",
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
      }
    }
  },
  "roles:identifiers": {
    "key0": "roles:identifiers1",
    "key1": "roles:identifiers0"
  }
}
```

