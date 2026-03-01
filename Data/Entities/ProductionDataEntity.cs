namespace Custom.HydrogenConfigurationSystem.Data.Entities
{
    public class ProductionDataEntity
    {
        public int Id { get; set; }
        public DateTime InsertTime { get; set; }
        public double ElectrolysisCurrent { get; set; }
        public double HydrogenOutput { get; set; }
        public double EnergyConsumption { get; set; }
        public double HydrogenPurity { get; set; }
        public double EnvironmentTemperature { get; set; }
        public double EnvironmentHumidity { get; set; }
        public double HydrogenConcentration { get; set; }
    }
}
