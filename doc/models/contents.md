
# Contents

## Structure

`Contents`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Tags` | `Dictionary<string, string>` | Required | A map of custom tags to deployment versions. Allows for defining a custom, persistent tag with a changing version number.<br>For example, `dev -> v1.2.3-dev`. This is useful when dealing with DNS LINKED records, where you always want dev.example.com to point to the<br>`dev` version of your app within an environment, where you can continuously deploy and update it without needing to change the record. It is<br>even more useful when you have multiple LINKED records, and you update i.e. `prod` tag to point to a new version, all records using the``prod` tag<br>are switched at once. |

## Example (as JSON)

```json
{
  "tags": {
    "key0": "tags5",
    "key1": "tags6",
    "key2": "tags7"
  }
}
```

