﻿using System.ComponentModel.DataAnnotations;

namespace Delta.SaleProject.Friendships.Dto
{
    public class CreateFriendshipRequestByUserNameInput
    {
        [Required(AllowEmptyStrings = true)]
        public string TenancyName { get; set; }

        public string UserName { get; set; }
    }
}