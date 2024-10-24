
# Balance Enum

How connections are balanced across your container instances. Can be one of the following:

- `roundrobin`: Each container instance is used in turns.
- `static-rr`: Each container instance is used in turns, but is faster than Round Robin at the expense of being less dynamic.
- `leastconn`: Routes traffic to the instance with the least number of active connections.
- `first`: Routes traffic to the first available instance.
- `source`: The same client IP always reaches the same container instance as long as no instance goes down or up.

## Enumeration

`BalanceEnum`

## Fields

| Name |
|  --- |
| `Roundrobin` |
| `Staticrr` |
| `Leastconn` |
| `First` |
| `Source` |

