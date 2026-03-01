namespace Custom.HydrogenConfigurationSystem.Globals
{
    public enum DeviceState
    {
        Running,
        Stopped,
        Alarm,
        Idle
    }

    public enum AlarmType
    {
        HighPressure,
        LowPressure,
        HighTemperature,
        LowTemperature,
        HighConcentration,
        LowConcentration,
        EquipmentFailure,
        PowerLoss
    }

    public enum UserRole
    {
        Admin,
        Operator,
        Visitor
    }

    public enum AuthType
    {
        Trial,
        Permanent
    }

    public enum ModuleType
    {
        Control,
        Monitor,
        Recipe,
        Log,
        Report,
        Config,
        User
    }
}
