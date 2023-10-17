using System;
using System.ComponentModel.DataAnnotations;

namespace UserAppWebApi.Core.Dtos
{
	public class UpdatePermissionDto
	{
        [Required(ErrorMessage = "UserName is required")]
        public string UserName { get; set; }

    }
}

