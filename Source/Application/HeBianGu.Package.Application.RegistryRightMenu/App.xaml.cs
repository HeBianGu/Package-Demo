using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace HeBianGu.Package.Application.RegistryRightMenu
{
    /// <summary>
    /// App.xaml 的交互逻辑
    /// </summary>
    public partial class App : System.Windows.Application
    {

        protected override void OnStartup(StartupEventArgs e)
        {

            if (e.Args != null && e.Args.Count() > 0)
            {
                foreach (var item in e.Args)
                {
                    var result = MessageBox.Show(item, "是否用默认程序打开？", MessageBoxButton.YesNo, MessageBoxImage.Question);

                    if (result == MessageBoxResult.Yes)
                    {
                        Process.Start(item);
                    }
                }
            }
            else
            {
                MessageBox.Show("没有识别到任何参数！");

                this.Shutdown();
            }
            base.OnStartup(e);
        }

    }
}
