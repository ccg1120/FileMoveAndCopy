using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FileUtility
{
    static class Program
    {
        /// <summary>
        /// 해당 애플리케이션의 주 진입점입니다.
        /// </summary>

        public static Form1 startform;

        [STAThread]
        static void Main()
        {
            StartSettingManager.StartSettingInit();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            startform = new Form1();
            //startform.LoadExtentionSetting(StartSettingManager.GetFileMoveSetting());
            StartSettingManager.SetStartOption();
            Application.Run(startform);

            

        }
    }
}
