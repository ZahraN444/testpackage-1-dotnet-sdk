
# Config 7

Configuration settings for the image.

## Structure

`Config7`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `User` | `string` | Required | The linux user this image runs its processes as. |
| `Ports` | [`List<Port>`](../../doc/models/port.md) | Required | The port settings for the image. |
| `Env` | `Dictionary<string, string>` | Required | Image defined environment variables for the image. |
| `Labels` | `Dictionary<string, string>` | Required | Image labels. |
| `Command` | `List<string>` | Required | The CMD array used to start the container. |
| `Entrypoint` | `List<string>` | Required | An entrypoint command. |
| `Volumes` | [`List<Volume>`](../../doc/models/volume.md) | Required | Volumes information for the given image. |
| `Workdir` | `string` | Required | The working directory for the image. |
| `SignalStop` | `string` | Required | A set command to be run if a signal is called. |

## Example (as JSON)

```json
{
  "user": "user0",
  "ports": [
    {
      "host": 55.68,
      "container": 138.72,
      "type": "type0"
    }
  ],
  "env": {
    "key0": "env9",
    "key1": "env0",
    "key2": "env1"
  },
  "labels": {
    "key0": "labels4",
    "key1": "labels5",
    "key2": "labels6"
  },
  "command": [
    "command3",
    "command4",
    "command5"
  ],
  "entrypoint": [
    "entrypoint0"
  ],
  "volumes": [
    {
      "path": "path0",
      "mode": "ro"
    }
  ],
  "workdir": "workdir6",
  "signal_stop": "signal_stop8"
}
```

