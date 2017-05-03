using System.Linq;
using ClickOnceTest.DataStorage;
using ClickOnceTest.DataStorage.Models;
using Microsoft.EntityFrameworkCore;

namespace ClickOnceTest
{
    public partial class MainWindow
    {
        public MainWindow()
        {
            InitializeComponent();
            Loaded += MainWindowLoaded;
        }

        private void MainWindowLoaded(object sender, System.Windows.RoutedEventArgs e)
        {
            using (var context = new TestDbContext())
                context.Database.Migrate();

            using (var context = new TestDbContext())
            {
                context.Users.Add(new UserModel());
                context.SaveChanges();
            }

            using (var context = new TestDbContext())
                UsersNumberRun.Text = context.Users.Count().ToString();
        }
    }
}
