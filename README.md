# AzureIotHub Explorer

AzureIotHub Explorer is a light weight win32 application to configure and monitor an instance of Azure IotHub.
This tool was built in a day to help developers to diagnose, capture messages and do a tiny bit of device management for 
the azure iot hub instances. It contains two distinct functionalities

- Device Management.
- Message Viewer.

## Connect 
The initial form is the connect form to add the connection string for the Azure IotHub instance use "iothubowner" policy for the connection string. 
![Connect form](https://y0qmxw-bn1305.files.1drv.com/y3mxIKm5YgrMx9wb0lNw2DcyaHBtIL2MnsFMieZJ53XfQ2T4Rc1uWDym-nub3gg9s0MH0NlpUSrFv79avj4blYIUNwQWyH-a0Uz3Hqzd3hEzvS9qOMx-v6Pk49G6RZkk1yvXG8-xpIpTlVa7HOrOPZxZjlcDzx1ap3CUeWpc3azf8U?width=393&height=175&cropmode=none)

the connection string would be automatically saved into a json file in the root folder and is autopopulated for next usage.

## Device Management
After the connection string is validated in the connect form a window opens with list of devices and information related. 
![Device Management](https://zkqgxw-bn1305.files.1drv.com/y3mt_jGbgYDDdD3210q_Z5Om5l4jHOiX6bbeGZaNbrO7fBrkD-Gh4z_63D2dlc46msMBOt1haQGAtqEzs7qt1u1Mb5h4I3-9HUTp51BiG7823MHztNwn9mP5iSh8R_Fi5_gHHYXsS2UKuSqTZ0xbDIOozn9npo33x1uuSGWF5NrSy0?width=757&height=529&cropmode=none)

The devices that are registered with the IotHub instance are listed with details such as 
- Id {Device ID}
- Status {Either enabled or disabled}
- Last Activity time {last time a message was transmitted by or for the device}
- C To D Message Count {Number of cloud to Device messages sent for the device for the day}
- Connection State {Whether the device is connected or not}

You can select and right click on the row to get actions that can be perfomed on the device.

![Right Click options](https://zkqhxw-bn1305.files.1drv.com/y3m1c1iXBNJYQtRW8j_19LRqga1yrSUQjn3ZCWNkVNk2ptQkeULsdvchX4oMk3MuG2HgkQ5OCMre3RzCT6VsIJMvnv2I39QNEoKvPLahSFNgDtj0b2RMJFaSmPicxetKERO1fl_TwY6pLJUlDqsiSTi2XQtkZVctITBHn39R3Zjy9s?width=757&height=532&cropmode=none)

#### Generate Connection String
On click of generate connection string, you could extract the connection string for the device and use it to connect the 
device using the [Azure Iot SDKs](https://github.com/Azure/azure-iot-sdks/blob/master/csharp/device/readme.md)

![Connection String](https://zkqfxw-bn1305.files.1drv.com/y3mD49qIAvKugDOc2kAKAitdHS0P-yRuXNmU61i0KRv03FL18jKFiJNqCwsFJnGr0uTPWkouSgfKGEGvSuHjFR0Z8EVkEIh7sdTVElEtW9qkL0KqooThuIScFIHjJ6y-TiTniSmEsR5lay8qZUXyKzt9ZRVt1lZR6kDAsowTciT4sU?width=492&height=192&cropmode=none)

#### Add Device
You can configure a device to IotHub registry and you can generate the connection string using above step to access it via code.
![Add Device](https://zkqexw-bn1305.files.1drv.com/y3mH0696fMdscmNzTznQHFr0StauewvzSmI5_KaoeRJqPG6Hh2HVURGrQnR8V10c0jNVPGxlUJ2Ni5O8FQKmp89B4f6IaM2hed2vs6C3cwjgpEOt-LgfsXkItfYkSJcWOured3JAWEsfWgNA1UMUlssbI-d7sv4eZjDam9NcrjyJq8?width=755&height=530&cropmode=none)

#### Remove Device
You can remove the selected device from the IotHub registry. 

#### Send Command To Device
On click of the option another window with selected device and ASCII as default encoding would open, you can send command to the selected device using this form.

![Send Command](https://zkqlxw-bn1305.files.1drv.com/y3mGivfgcK6fgE-MF4oTu7A0FWsxq5QHGt9InDRsxXS6qfDFbTwGjofRZH2e_aNo_iG6XNvlF2incJjMiuQhLvLZMYtA_IBLGtP9g9FjWGIK8b9b_cOTc349oH3kLotUgjzba02rpJSkMR6U-e7m_Q38kx0CqNAk9ZKIizn9_Ex2eE?width=755&height=531&cropmode=none)


>On checking the "refresh every min", the list of devices and its information would be refreshed every minute,
>On unchecking there will be no refresh of the devices.

## Message Viewer
In the device manager, if you click on the "Open Message Viewer" button another screen opens up with a listbox
and a button named "Start"

![Message Viewer](https://zkqixw-bn1305.files.1drv.com/y3mit-Z1sqH7G8dW1KzmslgSS9q1igwfY0OC1EefhBy0DnODH-6j9dPmwWWFkr7a-PibEe2MAHPkps21GwVqd-0wPAw0pHL9IGkRDnpk3TeHlSklI0ixZKadwiNyGnPmIiVpBWsTLgoppjLELpAIdcVa6PxiwRK19yuEFZjJBLQyfA?width=795&height=477&cropmode=none)

On click of "Start" the message viewer starts listening to the messages received by the Azure IotHub instance, and displayed
in the listbox in the following format

>  Partition:{partition_id} Message="{whatever_message_sent_by_device}"

You can copy the message format by right clicking and selecting copy option or you could also use CTRL + C.


