
# Extension

An image that is packaged with Cycle directly, such as the global load balancer.

## Structure

`Extension`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Identifier` | `string` | Required | A human-readable identifier used to refer to a resource, where using the official ID may be inconvenient.<br>The identifier is automatically tokenized from the name/relevant field of the resource if one is not provided. For example, a container named "My Container" will<br>have the identifier of `my-container` and is automatically created by the platform.<br><br>The identifier does not have to be unique. |

## Example (as JSON)

```json
{
  "identifier": "identifier4"
}
```

