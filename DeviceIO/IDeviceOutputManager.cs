public interface IDeviceOutputManager<TDevice, TDeviceOutputData> : IDeviceManager<TDevice> where TDevice : IDevice
{
    void SendOutput(TDevice target, TDeviceOutputData outputData);
}
