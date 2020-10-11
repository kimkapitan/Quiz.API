using EntityFrameworkCore.CommonTools;
using System.Collections.Generic;
using System.Linq;

namespace Quiz.DAL.Extensions
{
    public static class EntityExtensions
    {
        /// <summary>
        /// get all entities where IsDeleted == false
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="entities"></param>
        /// <returns></returns>
        [Expandable]
        public static IQueryable<T> NotDeleted<T>(this IEnumerable<T> entities) where T : class, IDeletionTrackable
        {
            return entities.AsQueryable().Where(e => !e.IsDeleted);
        }
    }
}
