# Smart Home Control Center

Concepts Used: Interface, Indexer, Enum, Encapsulation
Description:
Create an enum `DeviceType`: Light, Fan, AC, Heater
Create an interface `ISmartDevice` with methods:
- TurnOn(), TurnOff(), ShowStatus()
Create classes for each device type that implement `ISmartDevice`
Create a class `SmartHome` that contains devices indexed by `DeviceType`:
- home[DeviceType.Light] → returns the Light object
Demonstrate:
- Turning on/off devices using the indexer
- Printing device status
