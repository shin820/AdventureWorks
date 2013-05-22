using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace AdventureWorks.Model
{
    public class ObjectWithState
    {
        [NotMapped]
        public State State { get; set; }
        [NotMapped]
        public IDictionary<string, object> OriginalValues { get; set; }
    }

    public enum State
    {
        Added,
        UnChanged,
        Deleted
    }
}
