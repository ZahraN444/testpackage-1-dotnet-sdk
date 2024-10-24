
# Containers

Information about the assignment of the scoped variable to different containers in the environment.

## Structure

`Containers`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Global` | `bool` | Required | A boolean where true represents the scoped variables is globally assigned to all current and future containers in the environment. |
| `Ids` | `List<string>` | Optional | An array of container IDs, where each container identified will have access to the scoped variable. |
| `Identifiers` | `List<string>` | Optional | An array of container identifiers, where each container identfied will have access to the scoped variable. |

## Example (as JSON)

```json
{
  "global": false,
  "ids": [
    "ids7"
  ],
  "identifiers": [
    "identifiers2",
    "identifiers3",
    "identifiers4"
  ]
}
```

