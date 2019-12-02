using System;
using System.Collections.Generic;
using System.Text;

namespace OCPLibrary
{
  public class ExecutiveAccounts : IAccounts
  {
    EmployeeModel output = new EmployeeModel();


public EmployeeModel Create(IApplicantModel person)
    {
      output.FirstName = person.FirstName;
      output.LastName = person.LastName;
      output.EmailAddress = $"{person.FirstName}{person.LastName}@acmecorp.com";

      output.IsManager = true;
      output.IsExecutive = true;

      return output;
    }
  }
}
