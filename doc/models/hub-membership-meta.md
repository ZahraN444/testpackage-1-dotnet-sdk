
# Hub Membership Meta

A list of meta fields that can be applied to a membership.

## Structure

`HubMembershipMeta`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Capabilities` | [`Capabilities`](../../doc/models/capabilities.md) | Optional | - |

## Example (as JSON)

```json
{
  "capabilities": {
    "all": false,
    "specific": [
      "pipelines-view"
    ]
  }
}
```

