# IP Multicast Chat

## Summary

IP Multicast is a networking technique that allows efficient one-to-many communication by transmitting data to multiple receivers simultaneously using a single stream. Unlike broadcast (which sends to all hosts) or unicast (which sends to one host), multicast sends packets only to hosts that have joined a specific multicast group.

Multicast uses special IP addresses in the range 224.0.0.0 to 239.255.255.255 (IPv4) and relies on protocols like IGMP (Internet Group Management Protocol) to manage group membership.

## Challenge

- Create a multicast chat application that allows multiple users to communicate in a shared chat room
- Implement multicast socket functionality to:
  - Join a multicast group using a designated multicast IP address and port
  - Send messages to all members of the multicast group
  - Receive messages from other group members
- Handle user input and display incoming messages from other participants

## Bonus

- Add support for usernames/nicknames that appear with each message
- Include timestamps for each message
- Implement multiple chat rooms (different multicast groups)
- Add a command system (e.g., `/nick` to change username, `/quit` to leave)
- Support message formatting or basic emoticons
- Implement a discovery mechanism to list active participants
- Add TTL (Time-To-Live) configuration to control multicast scope

## Suggestions

- Common multicast group addresses for testing include 224.0.0.0 through 239.255.255.255
- Port numbers above 1024 are recommended to avoid requiring administrative privileges
- Test with multiple instances of your application on the same machine or local network
- Multicast may not work across all networks (some routers/switches block it)
- Consider setting socket options like `SO_REUSEADDR` to allow multiple instances on the same machine

## Notes and References

- [IP multicast - Wikipedia](https://en.wikipedia.org/wiki/IP_multicast)
- [RFC 1112 - Host Extensions for IP Multicasting](https://tools.ietf.org/html/rfc1112)
- [Multicast addressing - Wikipedia](https://en.wikipedia.org/wiki/Multicast_address)
- [Internet Group Management Protocol (IGMP)](https://en.wikipedia.org/wiki/Internet_Group_Management_Protocol)
