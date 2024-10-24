
# V1 Search Index Response

## Structure

`V1SearchIndexResponse`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Data` | [`Index`](../../doc/models/index.md) | Required | An index that enables search in the portal |

## Example (as JSON)

```json
{
  "data": {
    "generated": "01/30/2021 08:30:00",
    "hub_id": "hub_id2",
    "containers": {
      "key0": {
        "id": "id2",
        "name": "name2",
        "identifier": "identifier0",
        "state": "state8",
        "events": {
          "key0": "2016-03-13T12:52:32.123Z",
          "key1": "2016-03-13T12:52:32.123Z",
          "key2": "2016-03-13T12:52:32.123Z"
        },
        "context_blobs": [
          "context_blobs4"
        ],
        "associations": {
          "container": "container0",
          "environment": "environment4",
          "image-source": "image-source4",
          "image": "image8",
          "stack": "stack4"
        }
      }
    },
    "environments": {
      "key0": {
        "id": "id2",
        "name": "name2",
        "identifier": "identifier0",
        "state": "state8",
        "events": {
          "key0": "2016-03-13T12:52:32.123Z",
          "key1": "2016-03-13T12:52:32.123Z"
        },
        "context_blobs": [
          "context_blobs4",
          "context_blobs5"
        ],
        "associations": {
          "container": "container0",
          "environment": "environment4",
          "image-source": "image-source4",
          "image": "image8",
          "stack": "stack4"
        }
      }
    },
    "image_sources": {
      "key0": {
        "id": "id8",
        "name": "name8",
        "identifier": "identifier4",
        "state": "state6",
        "events": {
          "key0": "2016-03-13T12:52:32.123Z",
          "key1": "2016-03-13T12:52:32.123Z"
        },
        "context_blobs": [
          "context_blobs0",
          "context_blobs1"
        ],
        "associations": {
          "container": "container0",
          "environment": "environment4",
          "image-source": "image-source4",
          "image": "image8",
          "stack": "stack4"
        }
      }
    },
    "dns_zones": {
      "key0": {
        "id": "id0",
        "name": "name0",
        "identifier": "identifier2",
        "state": "state6",
        "events": {
          "key0": "2016-03-13T12:52:32.123Z"
        },
        "context_blobs": [
          "context_blobs2",
          "context_blobs3",
          "context_blobs4"
        ],
        "associations": {
          "container": "container0",
          "environment": "environment4",
          "image-source": "image-source4",
          "image": "image8",
          "stack": "stack4"
        }
      },
      "key1": {
        "id": "id0",
        "name": "name0",
        "identifier": "identifier2",
        "state": "state6",
        "events": {
          "key0": "2016-03-13T12:52:32.123Z"
        },
        "context_blobs": [
          "context_blobs2",
          "context_blobs3",
          "context_blobs4"
        ],
        "associations": {
          "container": "container0",
          "environment": "environment4",
          "image-source": "image-source4",
          "image": "image8",
          "stack": "stack4"
        }
      }
    },
    "stacks": {
      "key0": {
        "id": "id2",
        "name": "name2",
        "identifier": "identifier0",
        "state": "state8",
        "events": {
          "key0": "2016-03-13T12:52:32.123Z",
          "key1": "2016-03-13T12:52:32.123Z",
          "key2": "2016-03-13T12:52:32.123Z"
        },
        "context_blobs": [
          "context_blobs4"
        ],
        "associations": {
          "container": "container0",
          "environment": "environment4",
          "image-source": "image-source4",
          "image": "image8",
          "stack": "stack4"
        }
      },
      "key1": {
        "id": "id2",
        "name": "name2",
        "identifier": "identifier0",
        "state": "state8",
        "events": {
          "key0": "2016-03-13T12:52:32.123Z",
          "key1": "2016-03-13T12:52:32.123Z",
          "key2": "2016-03-13T12:52:32.123Z"
        },
        "context_blobs": [
          "context_blobs4"
        ],
        "associations": {
          "container": "container0",
          "environment": "environment4",
          "image-source": "image-source4",
          "image": "image8",
          "stack": "stack4"
        }
      },
      "key2": {
        "id": "id2",
        "name": "name2",
        "identifier": "identifier0",
        "state": "state8",
        "events": {
          "key0": "2016-03-13T12:52:32.123Z",
          "key1": "2016-03-13T12:52:32.123Z",
          "key2": "2016-03-13T12:52:32.123Z"
        },
        "context_blobs": [
          "context_blobs4"
        ],
        "associations": {
          "container": "container0",
          "environment": "environment4",
          "image-source": "image-source4",
          "image": "image8",
          "stack": "stack4"
        }
      }
    },
    "servers": {
      "key0": {
        "id": "id2",
        "name": "name2",
        "identifier": "identifier0",
        "state": "state8",
        "events": {
          "key0": "2016-03-13T12:52:32.123Z",
          "key1": "2016-03-13T12:52:32.123Z",
          "key2": "2016-03-13T12:52:32.123Z"
        },
        "context_blobs": [
          "context_blobs4"
        ],
        "associations": {
          "container": "container0",
          "environment": "environment4",
          "image-source": "image-source4",
          "image": "image8",
          "stack": "stack4"
        }
      },
      "key1": {
        "id": "id2",
        "name": "name2",
        "identifier": "identifier0",
        "state": "state8",
        "events": {
          "key0": "2016-03-13T12:52:32.123Z",
          "key1": "2016-03-13T12:52:32.123Z",
          "key2": "2016-03-13T12:52:32.123Z"
        },
        "context_blobs": [
          "context_blobs4"
        ],
        "associations": {
          "container": "container0",
          "environment": "environment4",
          "image-source": "image-source4",
          "image": "image8",
          "stack": "stack4"
        }
      },
      "key2": {
        "id": "id2",
        "name": "name2",
        "identifier": "identifier0",
        "state": "state8",
        "events": {
          "key0": "2016-03-13T12:52:32.123Z",
          "key1": "2016-03-13T12:52:32.123Z",
          "key2": "2016-03-13T12:52:32.123Z"
        },
        "context_blobs": [
          "context_blobs4"
        ],
        "associations": {
          "container": "container0",
          "environment": "environment4",
          "image-source": "image-source4",
          "image": "image8",
          "stack": "stack4"
        }
      }
    }
  }
}
```

