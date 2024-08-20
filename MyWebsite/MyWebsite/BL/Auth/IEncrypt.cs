using System;

namespace MyWebsite.BL.Auth
{
	public interface IEncrypt
	{
		string HashPassword(string password, string salt);
	}
}
