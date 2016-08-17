public delegate void DeviceInputReceivedEventHandler<TDevice, TInput>(TDevice source, TInput inputData) where TDevice : IDevice;

public interface IDeviceInputManager<TDevice, TDeviceInputData> : IDeviceManager<TDevice> where TDevice : IDevice
{
    event DeviceInputReceivedEventHandler<TDevice, TDeviceInputData> OnInputReceived;
}
