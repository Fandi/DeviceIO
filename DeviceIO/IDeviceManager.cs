public delegate void DeviceConnectionStatusChangedEventHandler<TDevice>(IDeviceManager<TDevice> source, TDevice device, bool isConnected) where TDevice : IDevice;
public delegate void DeviceConnectedEventHandler<TDevice>(IDeviceManager<TDevice> source, TDevice device) where TDevice : IDevice;
public delegate void DeviceDisconnectedEventHandler<TDevice>(IDeviceManager<TDevice> source, TDevice device) where TDevice : IDevice;

public interface IDeviceManager<TDevice> where TDevice : IDevice
{
    System.Collections.Generic.IReadOnlyCollection<TDevice> ConnectedDevices { get; }

    event DeviceConnectionStatusChangedEventHandler<TDevice> OnDeviceConnectionStatusChanged;
    event DeviceConnectedEventHandler<TDevice> OnDeviceConnected;
    event DeviceDisconnectedEventHandler<TDevice> OnDeviceDisconnected;
}

public interface IDeviceManager
{
    TDeviceManager GetDeviceManager<TDeviceManager, TDevice>() where TDeviceManager : IDeviceManager<TDevice> where TDevice : IDevice;
    IDeviceManager<TDevice> GetDeviceManager<TDevice>() where TDevice : IDevice;
}
