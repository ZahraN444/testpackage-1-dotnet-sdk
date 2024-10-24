
# Containers Meta

A list of meta fields that can be applied to a container.

## Structure

`ContainersMeta`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `InstancesCount` | [`ResourceCountSummary`](../../doc/models/resource-count-summary.md) | Optional | A summary of resources by state |
| `Domains` | [`List<Domain>`](../../doc/models/domain.md) | Optional | - |
| `Ips` | [`List<IP>`](../../doc/models/ip.md) | Optional | An array of IP resources. |

## Example (as JSON)

```json
{
  "instances_count": {
    "state": {
      "new": 0,
      "starting": 0,
      "running": 5,
      "stopping": 0,
      "deleting": 0,
      "deleted": 0
    },
    "total": 5,
    "available": 5
  },
  "domains": [
    {
      "fqdn": "fqdn2",
      "record": {
        "id": "id0",
        "hub_id": "hub_id2",
        "creator": {
          "id": "id8",
          "type": "employee"
        },
        "zone_id": "zone_id6",
        "name": "name0",
        "resolved_domain": "resolved_domain6",
        "type": {
          "a": {
            "ip": "ip6"
          },
          "aaaa": {
            "ip": "ip6"
          },
          "cname": {
            "domain": "domain4"
          },
          "ns": {
            "domain": "domain8"
          },
          "mx": {
            "priority": 20,
            "domain": "domain4"
          }
        },
        "features": {
          "certificate": {
            "id": "id8",
            "generated": "2016-03-13T12:52:32.123Z",
            "wildcard_child": false
          }
        },
        "state": {
          "current": "deleting",
          "changed": "2016-03-13T12:52:32.123Z",
          "error": {
            "message": "message4",
            "time": "2016-03-13T12:52:32.123Z"
          }
        },
        "events": {
          "key0": "2016-03-13T12:52:32.123Z",
          "key1": "2016-03-13T12:52:32.123Z",
          "key2": "2016-03-13T12:52:32.123Z"
        }
      }
    },
    {
      "fqdn": "fqdn2",
      "record": {
        "id": "id0",
        "hub_id": "hub_id2",
        "creator": {
          "id": "id8",
          "type": "employee"
        },
        "zone_id": "zone_id6",
        "name": "name0",
        "resolved_domain": "resolved_domain6",
        "type": {
          "a": {
            "ip": "ip6"
          },
          "aaaa": {
            "ip": "ip6"
          },
          "cname": {
            "domain": "domain4"
          },
          "ns": {
            "domain": "domain8"
          },
          "mx": {
            "priority": 20,
            "domain": "domain4"
          }
        },
        "features": {
          "certificate": {
            "id": "id8",
            "generated": "2016-03-13T12:52:32.123Z",
            "wildcard_child": false
          }
        },
        "state": {
          "current": "deleting",
          "changed": "2016-03-13T12:52:32.123Z",
          "error": {
            "message": "message4",
            "time": "2016-03-13T12:52:32.123Z"
          }
        },
        "events": {
          "key0": "2016-03-13T12:52:32.123Z",
          "key1": "2016-03-13T12:52:32.123Z",
          "key2": "2016-03-13T12:52:32.123Z"
        }
      }
    },
    {
      "fqdn": "fqdn2",
      "record": {
        "id": "id0",
        "hub_id": "hub_id2",
        "creator": {
          "id": "id8",
          "type": "employee"
        },
        "zone_id": "zone_id6",
        "name": "name0",
        "resolved_domain": "resolved_domain6",
        "type": {
          "a": {
            "ip": "ip6"
          },
          "aaaa": {
            "ip": "ip6"
          },
          "cname": {
            "domain": "domain4"
          },
          "ns": {
            "domain": "domain8"
          },
          "mx": {
            "priority": 20,
            "domain": "domain4"
          }
        },
        "features": {
          "certificate": {
            "id": "id8",
            "generated": "2016-03-13T12:52:32.123Z",
            "wildcard_child": false
          }
        },
        "state": {
          "current": "deleting",
          "changed": "2016-03-13T12:52:32.123Z",
          "error": {
            "message": "message4",
            "time": "2016-03-13T12:52:32.123Z"
          }
        },
        "events": {
          "key0": "2016-03-13T12:52:32.123Z",
          "key1": "2016-03-13T12:52:32.123Z",
          "key2": "2016-03-13T12:52:32.123Z"
        }
      }
    }
  ],
  "ips": [
    {
      "id": "id6",
      "hub_id": "hub_id8",
      "kind": "ipv4",
      "assignment": {
        "container_id": "container_id2",
        "instance_id": "instance_id4",
        "environment_id": "environment_id4"
      },
      "pool_id": "pool_id8",
      "address": "address2",
      "gateway": "gateway6",
      "cidr": "cidr6",
      "state": {
        "current": "releasing",
        "changed": "2016-03-13T12:52:32.123Z",
        "error": {
          "message": "message4",
          "time": "2016-03-13T12:52:32.123Z"
        }
      }
    },
    {
      "id": "id6",
      "hub_id": "hub_id8",
      "kind": "ipv4",
      "assignment": {
        "container_id": "container_id2",
        "instance_id": "instance_id4",
        "environment_id": "environment_id4"
      },
      "pool_id": "pool_id8",
      "address": "address2",
      "gateway": "gateway6",
      "cidr": "cidr6",
      "state": {
        "current": "releasing",
        "changed": "2016-03-13T12:52:32.123Z",
        "error": {
          "message": "message4",
          "time": "2016-03-13T12:52:32.123Z"
        }
      }
    },
    {
      "id": "id6",
      "hub_id": "hub_id8",
      "kind": "ipv4",
      "assignment": {
        "container_id": "container_id2",
        "instance_id": "instance_id4",
        "environment_id": "environment_id4"
      },
      "pool_id": "pool_id8",
      "address": "address2",
      "gateway": "gateway6",
      "cidr": "cidr6",
      "state": {
        "current": "releasing",
        "changed": "2016-03-13T12:52:32.123Z",
        "error": {
          "message": "message4",
          "time": "2016-03-13T12:52:32.123Z"
        }
      }
    }
  ]
}
```

