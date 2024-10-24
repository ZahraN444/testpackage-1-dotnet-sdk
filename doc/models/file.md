
# File

## Structure

`File`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Match` | `string` | Required | Regex string that describes the files to cache. |
| `Ttl` | `string` | Required | Time string that describes the time to live. |

## Example (as JSON)

```json
{
  "match": "(.*)\\\\.(js|jpg|css|png|svg)$",
  "ttl": "72h45m2s"
}
```

