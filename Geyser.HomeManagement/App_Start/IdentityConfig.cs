﻿using Geyser.HomeManagement.Infrastructure;
using Microsoft.AspNet.Identity;
using Microsoft.Owin;
using Microsoft.Owin.Security.Cookies;
using Owin;

namespace Geyser.HomeManagement
{
	public class IdentityConfig
	{
		public void Configuration(IAppBuilder app)
		{
			app.CreatePerOwinContext<AppIdentityDbContext>(AppIdentityDbContext.Create);
			app.CreatePerOwinContext<AppUserManager>(AppUserManager.Create);
			app.UseCookieAuthentication(new CookieAuthenticationOptions
			{
				AuthenticationType = DefaultAuthenticationTypes.ApplicationCookie,
				LoginPath = new PathString("/Account/Login"),
			});
		}
	}
}