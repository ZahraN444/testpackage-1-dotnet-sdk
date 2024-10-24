
# Instance Telemetry Network Snapshot

A snapshot of network usage statistics.

## Structure

`InstanceTelemetryNetworkSnapshot`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Interfaces` | [`List<InstanceTelemetryNetworkInterfaceSnapshot>`](../../doc/models/instance-telemetry-network-interface-snapshot.md) | Required | An array of network interfaces attached to this instance. |

## Example (as JSON)

```json
{
  "interfaces": [
    {
      "name": "name4",
      "rx_bytes": 48,
      "tx_bytes": 186
    }
  ]
}
```

