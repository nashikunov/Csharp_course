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

namespace StudentGrades.UI {
    /// <summary>
    /// Interaction logic for AddEditCourseWindow.xaml
    /// </summary>
    public partial class AddEditCourseWindow : Window {
        public Course Course { get; set; }

        public AddEditCourseWindow(Course course) {
            InitializeComponent();

            if (course != null) {
                Title = "Edit course";
                textBoxName.Text = course.Name;
                textBoxCredits.Text = course.Credits.ToString();
            }
            else
                Title = "Add course";
            textBoxName.Focus();
            Course = course;
        }

        private void ButtonOK_Click(object sender, RoutedEventArgs e) {
            if (string.IsNullOrWhiteSpace(textBoxName.Text)) {
                MessageBox.Show("Name cannot be empty", "Error");
                textBoxName.Focus();
                return;
            }

            if (!int.TryParse(textBoxCredits.Text, out int credits)) {
                MessageBox.Show("Incorrect value for the number of credits", "Error");
                textBoxCredits.Focus();
                return;
            }

            if (credits <= 0) {
                MessageBox.Show("Number of credits should be a positive value!", "Error");
                textBoxCredits.Focus();
                return;
            }

            // Creating a new course
            if (Course == null)
                Course = new Course();

            Course.Name = textBoxName.Text.Trim();
            Course.Credits = credits;
            DialogResult = true;
        }

        private void ButtonCancel_Click(object sender, RoutedEventArgs e) {
            DialogResult = false;
        }

        private void Window_PreviewKeyDown(object sender, KeyEventArgs e) {
            if (e.Key == Key.Enter) {
                ButtonOK_Click(sender, e);
                e.Handled = true;
            }
            else if (e.Key == Key.Escape) {
                ButtonCancel_Click(sender, e);
                e.Handled = true;
            }
        }
    }
}
