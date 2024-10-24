
# Mode Enum

The type of traffic expected by the load balancer for this port. Can be either:

- tcp: Traffic is forwarded without any parsing or additional manipulation.
- http: Traffic is treated as web traffic. If a LINKED record is configured for a container exposing this port, the domain will be parsed and it will be forwarded to the proper container. This allows multiple services to run on port 80 in the same environment.

## Enumeration

`ModeEnum`

## Fields

| Name |
|  --- |
| `Tcp` |
| `Http` |

