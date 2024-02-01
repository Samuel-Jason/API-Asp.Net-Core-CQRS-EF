using System.ComponentModel.DataAnnotations;
using System;
using Flunt.Validations;

namespace Todo.Domain.Commands.Contracts
{
    public interface ICommand : IValidatable
    {
        
    }
} 