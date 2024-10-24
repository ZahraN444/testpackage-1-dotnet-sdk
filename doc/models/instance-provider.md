
# Instance Provider

## Structure

`InstanceProvider`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Vendor` | `string` | Required | The vendor of the hub provider integration related to the server this instance runs on. |
| `IntegrationId` | `string` | Required | An ID of the provider Hub integration that this instance's host node is related to. |
| `Location` | `string` | Required | The identifier of the location related to the server this instance runs on. |

## Example (as JSON)

```json
{
  "vendor": "vendor8",
  "integration_id": "651586fca6078e98982dbd90",
  "location": "location6"
}
```

