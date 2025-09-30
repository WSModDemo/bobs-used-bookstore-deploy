using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Bookstore.Domain
{
    public abstract class Entity
    {
        [Column("id")]
        public int Id { get; set; }

        [Column("createdby")]
        public string CreatedBy { get; set; } = "System";

        public DateTime CreatedOn { get; set; } = DateTime.UtcNow;

        public DateTime UpdatedOn { get; set; } = DateTime.UtcNow;

        [Timestamp]
        [Column("rowversion")]
        public byte[] RowVersion { get; set; }

        public bool IsNewEntity()
        {
            return Id == 0;
        }
    }
}