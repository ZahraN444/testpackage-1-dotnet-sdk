
# Deployment

A logical grouping of containers inside of an Environment. Facilitates zero-downtime deployments by separating multiple versions of the same application within an environment.

If a container is a member of a deployment, it can only resolve containers in that same deployment, or containers NOT in a deployment. If a container is NOT a member of a deployment, it can resolve all containers in the environment.

## Structure

`Deployment`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Version` | `string` | Required | A version string representing the deployment. |

## Example (as JSON)

```json
{
  "version": "v1.2.3-dev"
}
```

