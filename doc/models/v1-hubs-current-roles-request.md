
# V1 Hubs Current Roles Request

## Structure

`V1HubsCurrentRolesRequest`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Name` | `string` | Optional | A name given to the Role. |
| `Identifier` | `string` | Required | - |
| `Capabilities` | [`Capabilities10`](../../doc/models/capabilities-10.md) | Optional | The list of platform level capabilities assigned to this Role. |
| `Rank` | `int` | Required | An integer between 0 and 10 that indicates the Role hierarchy. An account can only edit a Role that is less than their rank. The 'owner' Role is rank 10. |
| `Extra` | `Dictionary<string, string>` | Optional | Custom user-defined properties for storing extra information on the Role. Not utilized by Cycle. |

## Example (as JSON)

```json
{
  "name": "name6",
  "identifier": "identifier6",
  "capabilities": {
    "all": false,
    "specific": [
      "pipelines-view"
    ]
  },
  "rank": 164,
  "extra": {
    "key0": "extra8",
    "key1": "extra7",
    "key2": "extra6"
  }
}
```

