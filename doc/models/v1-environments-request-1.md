
# V1 Environments Request 1

## Structure

`V1EnvironmentsRequest1`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Name` | `string` | Optional | - |
| `Identifier` | `string` | Optional | - |
| `Version` | `string` | Optional | - |
| `About` | [`EnvironmentAbout`](../../doc/models/environment-about.md) | Optional | Contains details regarding the environment. |

## Example (as JSON)

```json
{
  "name": "name8",
  "identifier": "identifier4",
  "version": "version4",
  "about": {
    "description": "description4",
    "favorite": false
  }
}
```

