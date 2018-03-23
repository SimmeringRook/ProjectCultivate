using Cultivate_Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;


namespace Cultivate_Repositories.EntityFramework.ModelMaps
{
    public class InventoryItemMap
    {
        public InventoryItemMap(EntityTypeBuilder<InventoryItem> entityBuilder)
        {
            entityBuilder.HasKey(t => t.Id);
            entityBuilder.Property(t => t.Name).IsRequired();
            entityBuilder.Property(t => t.Amount).IsRequired();
            entityBuilder.Property(t => t.Measurement).IsRequired();
        }
    }
}
