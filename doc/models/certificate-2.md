
# Certificate 2

## Structure

`Certificate2`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Id` | `string` | Optional | A 24 character hex string used to identify a unique resource. |
| `Generated` | `DateTime?` | Optional | - |
| `WildcardChild` | `bool?` | Optional | A value where true represents that the certificate is using a shared wildcard cert. |

## Example (as JSON)

```json
{
  "id": "651586fca6078e98982dbd90",
  "generated": "01/30/2021 08:30:00",
  "wildcard_child": false
}
```

