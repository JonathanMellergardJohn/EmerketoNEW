using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace Emerketo.Areas.Identity.Data;

// Add profile data for application users by adding properties to the EmerketoUser class
public class EmerketoUser : IdentityUser
{
	public string FirstName { get; set; }
	public string LastName { get; set; }
}

