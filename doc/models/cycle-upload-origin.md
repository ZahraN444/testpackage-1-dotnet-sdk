
# Cycle Upload Origin

An image origin where the image is pushed directly to the factory, bypassing the need for a registry or external source.

In order to utilize this image origin type, a tar file of an OCI compliant image will need to be generated and pushed directly to the factory. The authentication token is generated when this image is created, and expires at the provided time.
Once you have a token, it can be uploaded as multipart form data under the key `file.tar`, directly to the factory at `https://factory.cycle.io:9414/v1/images/<IMAGE ID>/upload?hub-id=<HUB ID>&token=<TOKEN>`.

## Structure

`CycleUploadOrigin`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Type` | [`Type6Enum?`](../../doc/models/type-6-enum.md) | Optional | - |
| `Details` | [`Details11`](../../doc/models/details-11.md) | Optional | - |

## Example (as JSON)

```json
{
  "type": "cycle-upload",
  "details": {
    "expires": "2016-03-13T12:52:32.123Z",
    "token": "token4"
  }
}
```

