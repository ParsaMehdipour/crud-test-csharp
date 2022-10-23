using System;

namespace Mc2.CrudTest.Shared
{
    public abstract class BaseEntity<TKey>
    {
        public TKey Id { get; set; }
        public DateTime CreatedDate { get; set; }

        protected BaseEntity()
        {
            CreatedDate = DateTime.Now; ;
        }
    }

    public abstract class BaseEntity : BaseEntity<long>
    {

    }
}
