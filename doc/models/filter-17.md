
# Filter 17

## Structure

`Filter17`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `State` | `string` | Optional | `filter[state]=value` Filters integrations by their current state. For example, `filter[state]=active` would return only integrations in an active state. |
| `Search` | `string` | Optional | `filter[search]=value` Performs a text search across relevant fields of the integrations. For example, `filter[search]=example` would return integrations that have "example" in any of the searchable fields |
| `Identifier` | `string` | Optional | `filter[identifier]=value` Filters integrations by their identifier. For example, `filter[identifier]=abstraction` would return only integrations with the abstraction identifier. |
| `Category` | `string` | Optional | `filter[category]=value` Filters integrations by their category. For example, `filter[category]=infrastructure-provider` would return only integrations that are capable of provisioning infrastructure. |

## Example (as JSON)

```json
{
  "state": "state6",
  "search": "search4",
  "identifier": "identifier4",
  "category": "category4"
}
```

