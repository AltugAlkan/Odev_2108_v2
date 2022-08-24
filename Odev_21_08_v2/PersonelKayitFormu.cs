using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Odev_21_08_v2
{
    public partial class PersonelKayitFormu : Form
    {
        public PersonelKayitFormu()
        {
            InitializeComponent();
        }

        private void buttonDosyaSec_Click(object sender, EventArgs e)
        {
            OpenFileDialog file = new OpenFileDialog();
            file.InitialDirectory = "C:";     // C bölümünde açılacak
            //file.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);    // Masaüstünü açar
            file.Filter = "Excel Dosyası.xls";   // Excel dosyası kabul eder.
            file.FilterIndex = 2;   // İkinci filtre olarak açılacak. (Tam anlamadım :D)
            file.RestoreDirectory = true;  // Tekrar açtığınızda son yüklediğiniz dosyanın klasörünü açacak.
            file.CheckFileExists = false;  // Arattığımız dosya ismini klasörde arar.
            file.Title = "Excel Dosyası Seçiniz..";
            string DosyaYolu = file.FileName;  // Dosya yolunun verir.
            string DosyaAdi = file.SafeFileName; // Dosya adını verir.
            file.ShowDialog();
        }
    }
}
