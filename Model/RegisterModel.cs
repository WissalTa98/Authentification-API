﻿using System.ComponentModel.DataAnnotations;

namespace DevAuth.Model
{
	public class RegisterModel
	{
		[Required(ErrorMessage = "User Name is required")]
		public string? Username { get; set; }

		[EmailAddress]
		[Required(ErrorMessage = "Email is required")]
		public string? Email { get; set; }

		[Required(ErrorMessage = "Password is required")]
		public string? Password { get; set; }

		[Required(ErrorMessage = "Password is required")]
		public string? ConfirmPassword { get; set; }

		[Required(ErrorMessage = "FirstName is required")]
		public string? FirstName { get; set; }

		[Required(ErrorMessage = "LasttName is required")]
		public string? LastName { get; set; }

		//public UserRoles? UserRole { get; set; }
	}
}
