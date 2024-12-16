using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Common.Domain.Bases;
using Common.Domain.Exceptions;

namespace BooksManagement.Domain.Aggregates
{
    public class Author : BaseEntity
    {
        #region Properties
        public string Name { get; private set; } = string.Empty;
        #endregion

        #region Constructors
        private Author() { }
        public Author(string name)
        {
            NullEmptyException.CheckNotEmpty(name, nameof(name));
            Name = name;
        }
        #endregion

        #region Methods
        public void Edit(string name)
        {
            NullEmptyException.CheckNotEmpty(name, nameof(name));
            Name = name;
        }

        #endregion


    }
}
