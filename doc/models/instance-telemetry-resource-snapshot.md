
# Instance Telemetry Resource Snapshot

A resource snapshot that shows instance telemetry.

## Structure

`InstanceTelemetryResourceSnapshot`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Time` | `DateTime` | Required | A timestamp of the time this snapshot was captured at. |
| `HubId` | [`InstanceTelemetryResourceSnapshotHubId`](../../doc/models/containers/instance-telemetry-resource-snapshot-hub-id.md) | Optional | This is a container for any-of cases. |
| `ContainerId` | [`InstanceTelemetryResourceSnapshotContainerId`](../../doc/models/containers/instance-telemetry-resource-snapshot-container-id.md) | Optional | This is a container for any-of cases. |
| `InstanceId` | [`InstanceTelemetryResourceSnapshotInstanceId`](../../doc/models/containers/instance-telemetry-resource-snapshot-instance-id.md) | Optional | This is a container for any-of cases. |
| `EnvironmentId` | [`InstanceTelemetryResourceSnapshotEnvironmentId`](../../doc/models/containers/instance-telemetry-resource-snapshot-environment-id.md) | Optional | This is a container for any-of cases. |
| `ServerId` | [`InstanceTelemetryResourceSnapshotServerId`](../../doc/models/containers/instance-telemetry-resource-snapshot-server-id.md) | Optional | This is a container for any-of cases. |
| `Cluster` | [`InstanceTelemetryResourceSnapshotCluster`](../../doc/models/containers/instance-telemetry-resource-snapshot-cluster.md) | Optional | This is a container for any-of cases. |
| `Cpu` | [`InstanceTelemetryCPUSnapshot`](../../doc/models/instance-telemetry-cpu-snapshot.md) | Required | A telemetry snapshot pertaining to CPU usage. |
| `Memory` | [`InstanceTelemetryMemorySnapshot`](../../doc/models/instance-telemetry-memory-snapshot.md) | Required | A snapshot of memory usage statistics. |
| `Processes` | [`InstanceTelemetryProcessesSnapshot`](../../doc/models/instance-telemetry-processes-snapshot.md) | Required | Process information for a given snapshot. |
| `Network` | [`InstanceTelemetryNetworkSnapshot`](../../doc/models/instance-telemetry-network-snapshot.md) | Required | A snapshot of network usage statistics. |
| `Hugetlb` | [`HugeTLB`](../../doc/models/huge-tlb.md) | Optional | HugeTLB data. |

## Example (as JSON)

```json
{
  "time": "01/30/2021 08:30:00",
  "cpu": {
    "usage": {
      "total": 28,
      "per_core": [
        149
      ],
      "kernel": 198,
      "user": 104.98
    },
    "throttling": {
      "periods": 16,
      "throttled_periods": 178,
      "throttled_time": 246
    }
  },
  "memory": {
    "cache": 173.36,
    "usage": {
      "usage": 26.36,
      "max_usage": 92.64,
      "fail_count": 29.74,
      "limit": 31.94
    },
    "swap_usage": {
      "usage": 13.36,
      "max_usage": 79.64,
      "fail_count": 42.74,
      "limit": 237.06
    },
    "kernel_usage": {
      "usage": 162.76,
      "max_usage": 229.04,
      "fail_count": 149.34,
      "limit": 87.66
    },
    "kernel_tcp_usage": {
      "usage": 101.16,
      "max_usage": 167.44,
      "fail_count": 210.94,
      "limit": 149.26
    }
  },
  "processes": {
    "current": 78.92,
    "limit": 189.5
  },
  "network": {
    "interfaces": [
      {
        "name": "name4",
        "rx_bytes": 48,
        "tx_bytes": 186
      }
    ]
  },
  "hub_id": "String1",
  "container_id": "String5",
  "instance_id": "String3",
  "environment_id": "String7",
  "server_id": "String3"
}
```

