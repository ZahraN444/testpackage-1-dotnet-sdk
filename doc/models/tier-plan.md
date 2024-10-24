
# Tier Plan

A TierPlan object describes the attributes of a subscription tier

## Structure

`TierPlan`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Id` | `string` | Required | - |
| `Name` | `string` | Required | - |
| `Code` | `string` | Required | - |
| `Generation` | `int` | Required | - |
| `Usable` | `bool` | Required | - |
| `Price` | [`BillingAmount`](../../doc/models/billing-amount.md) | Required | An object holding information about term and amount that relates to a specific billing component. |
| `Servers` | [`BillingServers`](../../doc/models/billing-servers.md) | Required | An object holding information about servers included in Billing tier |
| `Members` | [`BillingMembers`](../../doc/models/billing-members.md) | Required | An object holding information about members included in Billing tier |
| `MaxNodes` | `int?` | Required | - |
| `MaxMembers` | `int?` | Required | - |
| `AdvancedFeatures` | [`AdvancedFeatures`](../../doc/models/advanced-features.md) | Required | - |
| `MaxDailyApiRequests` | `int?` | Required | - |
| `Ram` | [`BillingRam`](../../doc/models/billing-ram.md) | Required | An object holding information about servers included in Billing tier |
| `ImageStorage` | [`BillingImageStorage`](../../doc/models/billing-image-storage.md) | Required | An object holding information about servers included in Billing tier |
| `Builds` | [`BillingBuilds`](../../doc/models/billing-builds.md) | Required | An object holding information about servers included in Billing tier |
| `Hidden` | `bool` | Required | - |
| `Description` | `string` | Required | - |

## Example (as JSON)

```json
{
  "id": "id0",
  "name": "name0",
  "code": "code8",
  "generation": 92,
  "usable": false,
  "price": {
    "mills": 210,
    "term": "monthly"
  },
  "servers": {
    "included": 130.2,
    "hard_cap": false,
    "additional": {
      "mills": 68.92,
      "term": "monthly"
    }
  },
  "members": {
    "included": 101.26,
    "hard_cap": false,
    "additional": {
      "mills": 68.92,
      "term": "monthly"
    }
  },
  "max_nodes": 116,
  "max_members": 168,
  "advanced_features": {
    "gpu": false,
    "ial": false,
    "deployments": false,
    "autoscale": false
  },
  "max_daily_api_requests": 54,
  "ram": {
    "included_gb": 142.98,
    "additional_gb": {
      "mills": 25.1,
      "term": "monthly"
    },
    "hard_cap": false
  },
  "image_storage": {
    "included_gb": 228.24,
    "additional_gb": {
      "mills": 25.1,
      "term": "monthly"
    },
    "hard_cap": false
  },
  "builds": {
    "parallel": 112.22,
    "cpu_cores": 221.36,
    "ram_gb": 21.0,
    "max_daily_builds": 78
  },
  "hidden": false,
  "description": "description0"
}
```

