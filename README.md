# GattServer

## Project Description

A simple Gatt-Server for the Raspberry Pi Bluetooth writte in C# (.Net Framework 4.6.1)


## Requirements

### Mono
In order to run a .Net-Framwork program on a Linux system, a corresponding implementation of the .Net Framework for the host system is required.

[Mono Projekt](https://www.mono-project.com/) 

```
sudo apt-get install mono-complete
```

### Policy Settings
Adding the GattServer-Service to the Bluetooth-Policy

```
sudo nano /etc/dbus-1/system.d/bluetooth.conf
```

```
<policy user="root">
	<allow own="org.bluez"/>
	<allow send_destination="org.bluez"/>
	...
	<allow own="org.GattServer"/>
</policy>
```

### additional libarys
Additional libraries are required for this program. These are located in the folder [libs](.../master/libs) in the root directory.

* dbus-sharp
* Mono.Posix


## Infos

[Bluez](http://bluez.org)

[DBus Bluez-API](https://git.kernel.org/pub/scm/bluetooth/bluez.git/tree/doc)

[DBus .Net Libary](https://github.com/mono/dbus-sharp)