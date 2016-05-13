using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// “空白页”项模板在 http://go.microsoft.com/fwlink/?LinkId=234238 上提供

namespace Project
{
    /// <summary>
    /// 可用于自身或导航至 Frame 内部的空白页。
    /// </summary>
    public sealed partial class ChagePasswordPage : Page
    {
        public ChagePasswordPage()
        {
            this.InitializeComponent();
        }

        private void changePassword_Click(object sender, RoutedEventArgs e)
        {
            var db = App.conn;
            string Username = App.login_user.Username;
            string Password = password.Password;
            string sql_u = @"UPDATE  User SET Password = ? WHERE Username = ?";
            try
            {
                using (var insertment = db.Prepare(sql_u))
                {
                    insertment.Bind(1, Password);
                    insertment.Bind(2, Username);
                    insertment.Step();
                }
                var i = new Windows.UI.Popups.MessageDialog("successfully change!").ShowAsync();

            }
            catch (Exception ex)
            {
                var i = new Windows.UI.Popups.MessageDialog("Insert Defeat!").ShowAsync();
                throw (ex);
            }
        }
    }
}
