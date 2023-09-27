﻿using System;
using Topluluk.Shared.Enums;

namespace Topluluk.Services.User.Model.Dto.Follow
{
    public class FollowingUserDto
    {
        public string Id { get; init; }
        public string FirstName { get; init; }
        public string LastName { get; init; }
        public string UserName { get; init; }
        public string? ProfileImage { get; init; }
        public GenderEnum Gender { get; init; }
        public bool IsFollowing { get; init; } = true;
    }
}
