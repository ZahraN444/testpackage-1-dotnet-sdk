
# Index Component

Generic component format for describing resources for the search index

## Structure

`IndexComponent`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Id` | `string` | Required | ID of the component |
| `Name` | `string` | Required | Name of the component |
| `Identifier` | `string` | Optional | A human-readable identifier used to refer to a resource, where using the official ID may be inconvenient.<br>The identifier is automatically tokenized from the name/relevant field of the resource if one is not provided. For example, a container named "My Container" will<br>have the identifier of `my-container` and is automatically created by the platform.<br><br>The identifier does not have to be unique. |
| `State` | `string` | Required | State of the component |
| `Events` | `Dictionary<string, DateTime>` | Required | Describes the date and time at which certain events occurred in the lifetime of this resource. |
| `ContextBlobs` | `List<string>` | Required | related strings for fuzzy search |
| `Associations` | [`Associations`](../../doc/models/associations.md) | Required | Component associations |

## Example (as JSON)

```json
{
  "id": "id8",
  "name": "name8",
  "identifier": "identifier6",
  "state": "state4",
  "events": {
    "key0": "2016-03-13T12:52:32.123Z"
  },
  "context_blobs": [
    "context_blobs0",
    "context_blobs1",
    "context_blobs2"
  ],
  "associations": {
    "container": "container0",
    "environment": "environment4",
    "image-source": "image-source4",
    "image": "image8",
    "stack": "stack4"
  }
}
```

