
# Linked

A LINKED record is a record special to Cycle.  It represents a URL that points to a specific container or deployment of a container, however the IP address mapping in handled automatically by the platform.

## Structure

`Linked`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Features` | [`Features1`](../../doc/models/features-1.md) | Required | Features associated with this record. |
| `ContainerId` | [`LinkedContainerId`](../../doc/models/containers/linked-container-id.md) | Optional | This is a container for one-of cases. |
| `Deployment` | [`Deployment1`](../../doc/models/deployment-1.md) | Optional | Information about the deployment this record points to. |

## Example (as JSON)

```json
{
  "features": {
    "tls": {
      "enable": false
    }
  },
  "container_id": "String3",
  "deployment": {
    "environment_id": "environment_id0",
    "match": {
      "container": "container2",
      "tag": "String5"
    }
  }
}
```

