using SqlSugar;

namespace Custom.HydrogenConfigurationSystem.Data.Entities
{
    public class RecipeEntity
    {
        [SugarColumn(IsPrimaryKey = true, IsIdentity = true)]
        public int Id { get; set; }
        public string RecipeName { get; set; } = string.Empty;
        public string ApplicationScene { get; set; } = string.Empty;
        public double ElectrolysisCurrentMin { get; set; }
        public double ElectrolysisCurrentMax { get; set; }
        public double PurificationPressureMin { get; set; }
        public double PurificationPressureMax { get; set; }
        public double StoragePressure { get; set; }
        public double HydrogenFlowMin { get; set; }
        public double HydrogenFlowMax { get; set; }
        public double HydrogenPurity { get; set; }
    }
}
