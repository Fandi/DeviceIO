public delegate void DeviceConnectionStatusChangedEventHandler<TDevice>(IDeviceManager<TDevice> sender, TDevice device, bool isConnected) where TDevice : IDevice;
public delegate void DeviceConnectedEventHandler<TDevice>(IDeviceManager<TDevice> sender, TDevice device) where TDevice : IDevice;
public delegate void DeviceDisconnectedEventHandler<TDevice>(IDeviceManager<TDevice> sender, TDevice device) where TDevice : IDevice;

public interface IDeviceManager<TDevice> where TDevice : IDevice
{
    System.Collections.Generic.IReadOnlyCollection<TDevice> ConnectedDevices { get; }

    event DeviceConnectionStatusChangedEventHandler<TDevice> OnDeviceConnectionStatusChanged;
    event DeviceConnectedEventHandler<TDevice> OnDeviceConnected;
    event DeviceDisconnectedEventHandler<TDevice> OnDeviceDisconnected;
}

public interface IDeviceManager
{
    IDeviceManager<T> GetDeviceManager<T>() where T : IDevice;
}
