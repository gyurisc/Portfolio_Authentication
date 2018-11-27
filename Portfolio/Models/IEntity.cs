using System;

namespace Portfolio.Models
{
    public interface IEntity
    {
        int Id { get; }
        int OwnerId { get; set; }

        DateTime LastUpdated { get; set; }
        DateTime Created { get; set; }
    }    
}