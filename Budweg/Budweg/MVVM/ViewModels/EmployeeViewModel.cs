﻿using System;
using Budweg.MVVM.Models;
using Budweg.MVVM.ViewModels.Persistence;

namespace Budweg.MVVM.ViewModels
{
    public class EmployeeViewModel
    {
        private Employee source;

        public string Name { get; set; }
        public string Email { get; set; }
        public bool IsHR { get; set; }

        public EmployeeViewModel(Employee source)
        {
            this.source = source;

            Name = source.Name;
            Email = source.Email;
            IsHR = source.IsHR;
        }

        public void Delete()
        {
            throw new NotImplementedException();

            // RepositoryManager.EmployeeRepository.Delete(source);
        }
    }
}
