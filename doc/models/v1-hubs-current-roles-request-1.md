
# V1 Hubs Current Roles Request 1

## Structure

`V1HubsCurrentRolesRequest1`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Name` | `string` | Optional | A name given to the Role. |
| `Identifier` | `string` | Required | - |
| `Capabilities` | [`Capabilities1`](../../doc/models/capabilities-1.md) | Optional | The list of platform level capabilities assigned to this Role. |
| `Rank` | `int` | Required | - |
| `Extra` | `Dictionary<string, string>` | Optional | Custom user-defined properties for storing extra information on the Role. Not utilized by Cycle. |

## Example (as JSON)

```json
{
  "name": "name4",
  "identifier": "identifier8",
  "capabilities": {
    "all": false,
    "specific": [
      "pipelines-view"
    ]
  },
  "rank": 22,
  "extra": {
    "key0": "extra6",
    "key1": "extra5"
  }
}
```

