﻿using Farmino.Service.Commands.Interfaces;
using Farmino.Service.Commands.ProfileCommands.ValueModels;

namespace Farmino.Service.Commands.UserCommands
{
    public class RegisterUser : ICommand
    {
        public string Login { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
    }
}
