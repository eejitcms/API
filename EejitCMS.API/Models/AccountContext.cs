﻿using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EejitCMS.API.Models
{
	public class AccountContext : DbContext
	{
		public AccountContext(DbContextOptions<AccountContext> options) : base(options) { }

		public DbSet<Account> Accounts { get; set; }
	}
}
