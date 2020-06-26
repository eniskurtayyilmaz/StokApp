using StokUygulaması.EntityCrud;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StokUygulaması
{
    //TODO: Stok harektleri için hem girdisi hem çıktısı ile aynı ekranda olan bir şey değildir. Kullanıcıya sorarsın, hangi stok kartına giriş veya çıkış işlemi yapacaksın diye. Kullanıcı önce stok kartını seçer sonra bir form vasıtası ile combobox gibi bir şey ile giriş mi yoksa çıkış mı yapacağını seçer ve altına miktar girer. Sonrasında sen anlık kalan stoğu göstermelisin db view yapabilirsin. 
    //TODO: (DB İpucu: HAREKETID, STOKID, GIRISCIKISTYPE, HAREKETMIKTAR)
    public partial class StokTakip : Form
    {
        public StokTakip()
        {
            InitializeComponent();
        }
        public void BilgiGetir()
        {
            EntityByConnection Connection = new EntityByConnection();
            dataGridView1.DataSource = Connection.Db.StokHareketEkrani.ToList();
        }
        private void btnEkle_Click(object sender, EventArgs e)
        {
            //TODO: Kullanıcı ID'yi nerden bilsin, niye yazsın?! Seç düzenle gibi bir şey yapmak gerekir.
            EntityByAdded added = new EntityByAdded(Convert.ToInt32(txtid.Text), Convert.ToInt32(txtAdet.Text), Convert.ToInt32(textBox1.Text));
            BilgiGetir();
        }

        private void StokTakip_Load(object sender, EventArgs e)
        {
            BilgiGetir();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            //TODO: Kullanıcı ID'yi nerden bilsin, niye yazsın?! Seç düzenle gibi bir şey yapmak gerekir.
            EntityByDeleted deleted = new EntityByDeleted();
            deleted.EntityByDeletedMovements(Convert.ToInt32(txtid.Text));
            BilgiGetir();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            //TODO: Kullanıcı ID'yi nerden bilsin, niye yazsın?! Seç düzenle gibi bir şey yapmak gerekir.
            EntityByUpdated updated = new EntityByUpdated(Convert.ToInt32(txtid.Text), Convert.ToInt32(txtAdet.Text), Convert.ToInt32(textBox1.Text));
            BilgiGetir();
        }
    }
}
