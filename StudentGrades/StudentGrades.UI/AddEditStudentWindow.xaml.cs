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
using System.Windows.Shapes;


namespace StudentGrades.UI
{
    /// <summary>
    /// Логика взаимодействия для AddEditStudentWindow.xaml
    /// </summary>
    public partial class AddEditStudentWindow : Window
    {
        public Student Student { get; set; }

        //private SimpleRatingCalculator _calculator = new RatingCalculator();
        //private HSERatingCalculator _calculator = new HSERatingCalculator();
        private IRatingCalculator _calculator;



        public AddEditStudentWindow(Student student, IRatingCalculator calculator)
        {
            InitializeComponent();
            _calculator = calculator;

            if (student != null)
            {
                Title = "Edit student";
                textBoxName.Text = student.Name;
                dataGridGrades.ItemsSource = student.Grades;
                textBlockRating.Text = $"Rating: {_calculator.GetRating(student)}";
            }
            else
                Title = "Add course";
            textBoxName.Focus();
            Student = student;
        }

        //private int CalculateRating(Student student)
        //{
        //    int rating = 0;
        //    foreach (var grade in student.Grades)
        //        rating += grade.Value;
        //    return rating;
        //}

        private void ButtonOk_Click(object sender, RoutedEventArgs e)
        {
            if (Student == null)
                Student = new Student();
            Student.Name = textBoxName.Text.Trim();
            DialogResult = true;
        }

        private void ButtonCancel_Click(object sender, RoutedEventArgs e)
        {
            DialogResult = false;
        }
    }
}
