using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

namespace TestWPFApp
{
    /// <summary>
    /// Логика взаимодействия для TestWindow.xaml
    /// </summary>
    /// 
    

    public partial class TestWindow : Window
    {
        ObservableCollection<Employee> employees = new ObservableCollection<Employee>();
        ObservableCollection<Department> departments = new ObservableCollection<Department>();
       public TestWindow()
        {
            departments.Add(new Department("department1"));

            employees.Add(new Employee("Gurey", "department1"));
            employees.Add(new Employee("Gurey2", "department1"));


            InitializeComponent();
            EmpList.ItemsSource = employees;
            DepList.ItemsSource = departments;
            cbEmpDep.ItemsSource = departments;

        }

        private void SelectionChangedHandler(object sender, SelectionChangedEventArgs e)
        {
            txtEmpName.Text = employees[ EmpList.SelectedIndex].Name;
            cbEmpDep.Text = employees[EmpList.SelectedIndex].Department;


        }

        private void btnEmpSave_Click(object sender, RoutedEventArgs e)
        {
            employees[EmpList.SelectedIndex].Name = txtEmpName.Text;
            employees[EmpList.SelectedIndex].Department = cbEmpDep.Text;
        }

        private void btnEmpSaveNew_Click(object sender, RoutedEventArgs e)
        {
            employees.Add(new Employee(txtEmpName.Text,departments[cbEmpDep.SelectedIndex].Name));
            
        }

        private void DepList_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            txtDepName.Text = departments[DepList.SelectedIndex].Name;
        }

        private void btnDepSave_Click(object sender, RoutedEventArgs e)
        {
            Department d = (Department)DepList.SelectedItem;
            d.Name = txtDepName.Text;
            
        }

        private void btnDepSaveNew_Click(object sender, RoutedEventArgs e)
        {
            departments.Add(new Department(txtDepName.Text));
        }
    }
}
