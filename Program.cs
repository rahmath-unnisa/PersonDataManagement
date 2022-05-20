using System;
using PersonDataManagement;
  
PersonManagement personManagement = new PersonManagement();
personManagement.AddDefaultData();
personManagement.GetTopRecords();
personManagement.GetRecords();
personManagement.AvarageRecords();
personManagement.GetValue();
personManagement.SkipRecords();
personManagement.RemoveRecords();