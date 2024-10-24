
# Instance

An instance of a Container.

## Structure

`Instance`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Id` | `string` | Required | A 24 character hex string used to identify a unique resource. |
| `Creator` | [`CreatorScope`](../../doc/models/creator-scope.md) | Required | The creator scope is embedded in resource objects to describe who created them |
| `HubId` | `string` | Required | The unique ID of the Hub this resource was created in. |
| `ContainerId` | `string` | Required | A container identifier for the container that is associated with this instance. |
| `LocationId` | `string` | Required | A location identifier that's associated with the server this instance is deployed to. |
| `Environment` | [`EnvironmentNetworkSummary`](../../doc/models/environment-network-summary.md) | Required | Details about the environment network this instance is a member of. |
| `Stateful` | [`Stateful2`](../../doc/models/stateful-2.md) | Optional | If the instance is stateful, additional details relating to its stateful properties. |
| `Function` | [`Function`](../../doc/models/function.md) | Optional | If the instance is a function, additional details relating to its function properties |
| `Provider` | [`InstanceProvider`](../../doc/models/instance-provider.md) | Required | - |
| `ServerId` | `string` | Required | An identifier for the server this instance is deployed to. |
| `ReadyState` | [`ReadyStateEnum`](../../doc/models/ready-state-enum.md) | Required | The state as it relates to the following. * `active` - instance can be started or stopped. * `purge` - instance should be deleted. * `hibernate` - instance is active but not allowed to run. * `configuring` - this instance is not allowed to start yet |
| `PurgeTime` | [`InstancePurgeTime`](../../doc/models/containers/instance-purge-time.md) | Optional | This is a container for any-of cases. |
| `Hostname` | `string` | Required | The hostname of the instance. |
| `Service` | [`ServiceContainerIdentifier1Enum?`](../../doc/models/service-container-identifier-1-enum.md) | Optional | The type of service this instance is within the environment, if any. |
| `State` | [`InstanceState`](../../doc/models/instance-state.md) | Required | Information about the state of an instance. |
| `Autoscale` | [`InstanceAutoscale`](../../doc/models/containers/instance-autoscale.md) | Optional | This is a container for any-of cases. |
| `Migration` | [`InstanceMigration2`](../../doc/models/containers/instance-migration-2.md) | Optional | This is a container for any-of cases. |
| `Deployment` | [`InstanceDeployment`](../../doc/models/containers/instance-deployment.md) | Optional | This is a container for any-of cases. |
| `Events` | [`InstanceEvents`](../../doc/models/instance-events.md) | Required | A collection of timestamps for each event in the instnaces lifetime. |

## Example (as JSON)

```json
{
  "id": "651586fca6078e98982dbd90",
  "creator": {
    "id": "651586fca6078e98982dbd90",
    "type": "employee"
  },
  "hub_id": "651586fca6078e98982dbd90",
  "container_id": "container_id2",
  "location_id": "location_id0",
  "environment": {
    "id": "651586fca6078e98982dbd90",
    "network_subnet": "network_subnet0",
    "subnet": "subnet4",
    "ipv6": {
      "ip": "fd00::21:0:0:0",
      "cidr": "fd00::21:0:0:0/96"
    },
    "legacy": {
      "host": 138,
      "subnet": 90,
      "ipv4": {
        "ip": "fd00::21:0:0:0",
        "cidr": "fd00::21:0:0:0/96"
      }
    },
    "mac_addr": "mac_addr0",
    "vxlan_tag": 174
  },
  "provider": {
    "vendor": "vendor4",
    "integration_id": "651586fca6078e98982dbd90",
    "location": "location2"
  },
  "server_id": "651586fca6078e98982dbd90",
  "ready_state": "active",
  "hostname": "hostname8",
  "state": {
    "current": "reimaging",
    "changed": "01/30/2021 08:30:00",
    "health": {
      "healthy": false,
      "updated": "2016-03-13T12:52:32.123Z"
    },
    "error": {
      "message": "message4",
      "time": "2016-03-13T12:52:32.123Z"
    }
  },
  "events": {
    "created": "01/30/2021 08:30:00",
    "updated": "01/30/2021 08:30:00",
    "deleted": "01/30/2021 08:30:00"
  },
  "stateful": {
    "id": "id6",
    "base_hostname": "base_hostname6"
  },
  "function": {
    "seed": 122
  },
  "purge_time": "2016-03-13T12:52:32.123Z",
  "service": "loadbalancer",
  "autoscale": {
    "sibling_id": "sibling_id6",
    "min_ttl": "2016-03-13T12:52:32.123Z"
  }
}
```

