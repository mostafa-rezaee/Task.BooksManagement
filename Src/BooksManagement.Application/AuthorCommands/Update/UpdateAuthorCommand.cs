using Common.Application.Bases;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BooksManagement.Application.AuthorCommands.Update
{
    public class UpdateAuthorCommand : IBaseCommand
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public UpdateAuthorCommand(Guid id, string name)
        {
            Id = id;
            Name = name;
        }
    }
}
