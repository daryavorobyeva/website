using System;

namespace MyWebsite.BL.Auth
{
	public interface ICurrentUser
	{
		bool IsLoggedIn();
	}
}
