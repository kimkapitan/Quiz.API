using EntityFrameworkCore.CommonTools;
using System;

namespace Quiz.DAL.Entities.Base
{
    /// <summary>
    /// Base entity types
    /// </summary>
    /// <typeparam name="TKey"></typeparam>
    public class EntityBase<TKey> : IEntityBase<TKey>
    {
        public TKey Id { get; set; }
        public DateTime? DeletedUtc { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime? UpdatedUtc { get; set; }
        public DateTime CreatedUtc { get; set; }
    }

    public interface IEntityBase<TKey> : IEntityBase
    {
        TKey Id { get; set; }
    }

    public interface IEntityBase : IDeletionTrackable, IModificationTrackable, ICreationTrackable
    {
    }
}
