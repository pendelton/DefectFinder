using System;
using System.Collections.Generic;
using System.Windows.Forms;
using DefectFinder.Model;

namespace DefectFinder
{
    public partial class ConsoleView : UserControl, IConsoleView
    {
        public ConsoleView()
        {
            InitializeComponent();
        }

        public void PrintProject(Project project)
        {
            throw new System.NotImplementedException();
        }

        public void PrintProjects(List<Project> projects)
        {
            foreach (var project in projects)
            {
                textBox_Console.Text += project + Environment.NewLine;
            }
        }

        public void Clear()
        {
            textBox_Console.Clear();
        }

        public void PrintError(Exception ex)
        {
            textBox_Console.Text = ex.Message;
        }
    }

    public interface IConsoleView
    {
        void PrintProject(Project project);
        void PrintProjects(List<Project> projects);
        void Clear();
        void PrintError(Exception ex);
    }
}
