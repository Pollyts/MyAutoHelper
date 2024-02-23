using Microsoft.AspNetCore.Identity;

namespace MyAutoHelper.Database.Models
{
    public interface IUniqueEntity
    {
        public int Id { get; set; }
    }
}