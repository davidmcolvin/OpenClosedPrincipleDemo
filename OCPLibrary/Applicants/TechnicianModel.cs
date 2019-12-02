using System;
using System.Collections.Generic;
using System.Text;

namespace OCPLibrary
{
  public class TechnicianModel
  {
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public IAccounts AccountProcessor { get; set; } = new Accounts();
  }
}
