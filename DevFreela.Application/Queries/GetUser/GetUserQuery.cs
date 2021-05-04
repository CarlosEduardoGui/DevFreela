﻿using DevFreela.Application.ViewModels;
using MediatR;

namespace DevFreela.Application.Queries.GetUser
{
    public class GetUserQuery : IRequest<UserViewModel>
    {
        public int Id { get; set; }

        public GetUserQuery(int id)
        {
            Id = id;
        }
    }
}
