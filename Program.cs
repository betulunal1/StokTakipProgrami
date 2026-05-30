using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Stok_Program
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
       
            static void Main()
            {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);

                // Önce giriş ekranını oluşturup açıyoruz
                Form_Login login = new Form_Login();

                // Eğer kullanıcı doğru şifre girip OK sonucunu döndürdüyse
                if (login.ShowDialog() == DialogResult.OK)
                {
                    Application.Run(new Form1()); // Esas ana menüyü (Form1) çalıştır
                }
            }





            
        
    }
}
