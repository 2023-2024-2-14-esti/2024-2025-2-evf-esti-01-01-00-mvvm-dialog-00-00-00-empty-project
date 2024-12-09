﻿using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Kreta.Models;
using System.Collections.ObjectModel;

namespace Kreta.ViewModel
{
    public partial class StudentViewModel : ObservableObject
    {
        [ObservableProperty]
        private Student _student = new Student();

        [ObservableProperty]
        private List<String> _educationLevels = new List<String>()
        { "érettségi", "szakmai érettségi", "szakmai vizsga" };

        [ObservableProperty]
        private ObservableCollection<Student> _students = new ObservableCollection<Student>();

        public StudentViewModel()
        {
            _student.BirthsDay = DateTime.Now;
        }

        [RelayCommand]
        public void DoAddNewStudent(Student newStudent)
        {
            Students.Add(newStudent);
        }

        [RelayCommand]
        public void DoRemoveStudent(Student studentToDelete)
        {
            Students.Remove(studentToDelete);
        }

        [RelayCommand]
        public void DoNewStudent()
        {
            Student = new Student();
        }
    }
}
