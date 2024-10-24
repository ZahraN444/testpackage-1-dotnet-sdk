
# Cluster Version Server Count

A count of servers in a cluster with the given version of Cycle software

## Structure

`ClusterVersionServerCount`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Agent` | `Dictionary<string, double>` | Required | - |
| `AgentSpawner` | `Dictionary<string, double>` | Required | - |
| `Compute` | `Dictionary<string, double>` | Required | - |
| `ComputeSpawner` | `Dictionary<string, double>` | Required | - |

## Example (as JSON)

```json
{
  "agent": {
    "key0": 213.09
  },
  "agent-spawner": {
    "key0": 87.55,
    "key1": 87.56
  },
  "compute": {
    "key0": 85.85,
    "key1": 85.86,
    "key2": 85.87
  },
  "compute-spawner": {
    "key0": 200.73,
    "key1": 200.74,
    "key2": 200.75
  }
}
```

