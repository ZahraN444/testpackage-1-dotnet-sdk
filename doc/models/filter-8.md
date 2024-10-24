
# Filter 8

## Structure

`Filter8`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Creator` | `string` | Optional | `filter[creator]=account-ID` filter for containers matching a particular creator, such as `account-ID` or `environment-ID` |
| `Identifier` | `string` | Optional | `filter[identifier]=value` List only those containers matching this identifier. May return multiple results. |
| `Search` | `string` | Optional | `filter[search]=value` search containers for a value associated with a field on the given container(s). |
| `State` | `string` | Optional | `filter[state]=value1,value2` state filtering will allow you to filter by the container's current state. |
| `Service` | `string` | Optional | `filter[service]=value` service filtering will allow you to filter by service type: `loadbalancer`, `discovery`, `vpn`. |
| `PublicNetwork` | `string` | Optional | `filter[public_network]=value` public network filtering will allow you to filter by the containers network settings: `enabled`, `disabled`, `egress-only`. |
| `Image` | `string` | Optional | `filter[image]=ID` image filtering by ID.  Submit the ID of the image you wish to filter for and the return will be any containers currently using the image. |
| `Environment` | `string` | Optional | `filter[environment]=ID` environment filtering by ID.  Submit the ID of the environment you wish to filter for and the return will be any containers in that environment. |
| `Tags` | `string` | Optional | `filter[tags]=tagone,tagtwo,tagthree` container filtering using server tags. If the container has the tags you submit it will be part of the return. |
| `Stack` | `string` | Optional | `filter[stack]=ID` stack filtering by ID.  Submit the ID of the stack you wish to filter for and the return will be any containers deployed associated with 'containers' from the stack. |
| `Deployment` | `string` | Optional | `filter[deployment]=v1,v2` filter containers by deployment(s). |
| `RangeStart` | `DateTime?` | Optional | The start date from when to pull the containers |
| `RangeEnd` | `DateTime?` | Optional | The end date from when to pull the containers |

## Example (as JSON)

```json
{
  "range-start": "01/30/2021 08:30:00",
  "range-end": "01/30/2021 08:30:00",
  "creator": "creator4",
  "identifier": "identifier4",
  "search": "search4",
  "state": "state2",
  "service": "service6"
}
```

