
# Factory

Information about the Factory service that built/imported the Image into Cycle.

## Structure

`Factory`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `NodeId` | `string` | Required | The node holding the factory service that was responsible for building the image. |
| `Cached` | `DateTime` | Required | A date timestamp for when the node cached the image. |
| `Acknowledged` | `DateTime` | Required | A date timestamp for when the node acknowledged the image import job. |

## Example (as JSON)

```json
{
  "node_id": "node_id4",
  "cached": "01/30/2021 08:30:00",
  "acknowledged": "01/30/2021 08:30:00"
}
```

