using Domain.Common.Contracts;

namespace Domain.Entities;

public class Farmer : AuditableEntity
{
          public string Name{get; private set;}
          public string PhoneNumber{get; private set;}
          public Farmer(string name, string phoneNum)
          {
                    Name = name;
                    PhoneNumber = phoneNum;
          }
}
