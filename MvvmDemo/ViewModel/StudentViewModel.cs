﻿using MvvmDemo.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MvvmDemo.ViewModel
{
    class StudentViewModel
    {

        public StudentViewModel()
        {
            LoadStudents();

        }

        public ObservableCollection <Student> Students
        {
            get;
            set;
        }

        public void LoadStudents()
        {
            ObservableCollection<Student> students = new ObservableCollection<Student>();

            students.Add(new Student { FirstName = "Adam", LastName = "Nowak" });
            students.Add(new Student { FirstName = "Jan", LastName = "Kowalski" });
            students.Add(new Student { FirstName = "Michał", LastName = "Milowicz" });

            Students = students;
        }
    }
}
