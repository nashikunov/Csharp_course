using StudentGrades.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace StudentGrades.UI {
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window {
        Repository _repo = new Repository();

        public MainWindow() {
            InitializeComponent();

            UpdateCourseList();

            listBoxStudents.ItemsSource = _repo.Students;
        }

        

        private void UpdateCourseList() {
            listBoxCourses.ItemsSource = null;
            listBoxCourses.ItemsSource = _repo.Courses;
        }

        private void UpdateStudentList()
        {
            listBoxStudents.ItemsSource = null;
            listBoxStudents.ItemsSource = _repo.Students;
        }

        private void ButtonAddCourse_Click(object sender, RoutedEventArgs e) {
            var courseWindow = new AddEditCourseWindow(null);
            if (courseWindow.ShowDialog() == true) {
                _repo.Courses.Add(courseWindow.Course);
                UpdateCourseList();
            }
        }

        private void ButtonEditCourse_Click(object sender, RoutedEventArgs e) {
            var selectedCourse = listBoxCourses.SelectedItem as Course;
            if (selectedCourse == null) {
                MessageBox.Show("Select a course from the list");
                return;
            }

            var courseWindow = new AddEditCourseWindow(selectedCourse);
            if (courseWindow.ShowDialog() == true)
                UpdateCourseList();
        }

        private void ButtonRemoveCourse_Click(object sender, RoutedEventArgs e) {
            var selectedCourse = listBoxCourses.SelectedItem as Course;
            if (selectedCourse == null) {
                MessageBox.Show("Select a course from the list");
                return;
            }

            if (_repo.CanDeleteCourse(selectedCourse)) {
                _repo.Courses.Remove(selectedCourse);
                UpdateCourseList();
            }
            else {
                MessageBox.Show("Unable to remove course as marks have been already assigned");
            }
                
        }

        IRatingCalculator _calculator = new HSERatingCalculator();

        private void ButtonAddStudent_Click(object sender, RoutedEventArgs e)
        {
            var studentWindow = new AddEditStudentWindow(null, _calculator);
            if (studentWindow.ShowDialog() == true)
            {
                _repo.Students.Add(studentWindow.Student);
                UpdateStudentList();
            }
        }

        private void ButtonEditStudent_Click_1(object sender, RoutedEventArgs e)
        {
            var selectedStudent = listBoxStudents.SelectedItem as Student;
            if (selectedStudent == null)
            {
                MessageBox.Show("Select a course from the list");
                return;
            }

            var studentWindow = new AddEditStudentWindow(selectedStudent, _calculator);
            if (studentWindow.ShowDialog() == true)
                UpdateStudentList();

        }

        private void ButtonRemoveStudent_Click_2(object sender, RoutedEventArgs e)
        {
            var selectedStudent = listBoxStudents.SelectedItem as Student;
            if (selectedStudent == null)
            {
                MessageBox.Show("Select a student from the list");
                return;
            }
            
                _repo.Students.Remove(selectedStudent);
                UpdateStudentList();
                        
        }

        
    }
}
