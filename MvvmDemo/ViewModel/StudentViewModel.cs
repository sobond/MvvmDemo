using MvvmDemo.Model;
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

        public ObservableCollection<Student> Students { get; set; }
        public MyICommand DeleteCommand { get; set; }

        public StudentViewModel()
        {
            LoadStudents();
            DeleteCommand = new MyICommand(OnDelete, CanDelete);

        }

        public void LoadStudents()
        {
            ObservableCollection<Student> students = new ObservableCollection<Student>();

            students.Add(new Student { FirstName = "Adam", LastName = "Nowak" });
            students.Add(new Student { FirstName = "Jan", LastName = "Kowalski" });
            students.Add(new Student { FirstName = "Michał", LastName = "Milowicz" });

            Students = students;
        }

        private Student _selectedStudent;

        public Student SelectedStudent
        {
            get
            {
                return _selectedStudent;
            }

            set
            {
                _selectedStudent = value;
                DeleteCommand.RaiseCanExecuteChanged();
            }
        }

        private void OnDelete()
        {
            Students.Remove(SelectedStudent);
        }

        private bool CanDelete()
        {
            return SelectedStudent != null;
        }


    }
}
