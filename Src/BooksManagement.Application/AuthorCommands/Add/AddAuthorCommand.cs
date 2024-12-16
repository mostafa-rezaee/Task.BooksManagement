using Common.Application.Bases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BooksManagement.Application.AuthorCommands.Add
{
    public class AddAuthorCommand : IBaseCommand
    {
        public string Name { get; set; }
        public AddAuthorCommand(string name)
        {
            Name = name;
        }
    }
}
