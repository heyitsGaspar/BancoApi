﻿using Aplication.DTOs.Users;
using Aplication.Grappers;
using Aplication.Interfaces;

using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Aplication.Feautres.Authtenticate.Commands.AuthenticateCommand
{

    public class AuthenticateCommand : IRequest<Response<AuthenticationResponse>>
    {
        public string Email { get; set; }
        public string Password { get; set; }
        public string IpAddress { get; set; }
    }

    public class AuthenticateCommandHandler : IRequestHandler<AuthenticateCommand, Response<AuthenticationResponse>>
    {
        private readonly IAccountService _accountService;

        public AuthenticateCommandHandler(IAccountService accountService)
        {
            _accountService = accountService;
        }

        public async Task<Response<AuthenticationResponse>> Handle(AuthenticateCommand request, CancellationToken cancellationToken)
        {
            return await _accountService.AuthenticateAsync(new AuthenticationRequest
            {
                Email = request.Email,
                Password = request.Password
            }, request.IpAddress);
        }
    }
}
