
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Form1.cs;

global int counter = 0;

private void OlusturBilet()
{
    // Bilet oluşturma işlemleri
    string nereden = nereden_combobox.Text;
    string nereye = nereye_combobox.Text;
    string sefer = sefer_combobox.Text;
    // int koltukNo = (int)koltuk_numarasi_numupdown.Value;
    int Id = counter;
    counter++;
    // Bilet oluşturulduğunu göstermek için bir iletişim kutusu göster
    MessageBox.Show($"Bilet Oluşturuldu!\nNereden: {nereden}\nNereye: {nereye}\nSefer: {sefer}\n Bilet ID: {Id}");

    // Oluşturulan bilet bilgilerini sıfırla veya gerekli işlemleri yap
    nereden_combobox.SelectedIndex = 0;
    nereye_combobox.SelectedIndex = 0;
    sefer_combobox.SelectedIndex = 0;
    koltuk_numarasi_numupdown.Value = 0;

}