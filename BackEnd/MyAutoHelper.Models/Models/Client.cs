using Microsoft.AspNetCore.Identity;

namespace MyAutoHelper.Database.Models
{
    public class Client : IUniqueEntity
    {
        public int Id { get; set; }
    }
}