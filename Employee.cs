using System;
using System.ComponentModel.DataAnnotations;


using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;




namespace ZooBookApi.Models
{
public class Employee{
public int ID { get; set; }
public string FirstName { get; set; }
 public string MiddleName{ get; set; }  
 public string  LastName{ get; set; }  
}
}

