
# Extra

Additional entries on the error object to provide extra details.

## Structure

`Extra`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Capability` | [`Capability1Enum?`](../../doc/models/capability-1-enum.md) | Optional | If the error occured because of a lack of permission (403), this will list the specific capability that the Role/API Key is missing. |

## Example (as JSON)

```json
{
  "capability": "stacks-builds-deploy"
}
```

