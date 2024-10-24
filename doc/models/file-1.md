
# File 1

File is an object that describes a path to mount the file to inside the container.

## Structure

`File1`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Decode` | `bool` | Required | When true, Cycle will interpret this variable as a base-64 encoded string, and decode it before passing it into the container. |
| `Path` | `string` | Required | The path to mount the file to inside the container. |

## Example (as JSON)

```json
{
  "decode": false,
  "path": "/var/run/cycle/variables/<myVariable>"
}
```

