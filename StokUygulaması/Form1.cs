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
    //TODO: Tasarım berbat
    //TODO: Türkçe karakter kullanmamalısın projelerde.
    public partial class StokKartı : Form
    {

        public StokKartı()
        {
            InitializeComponent();
        }
        public void BilgiGetir()
        {
            //Bu kodu (EntityByConnection Connection ) public yap //EntityByAdded.cs satır 11 gibi
            EntityByConnection Connection = new EntityByConnection();
            dataGridView1.DataSource = Connection.Db.StokKartı.ToList();
        }

        private void btnGit_Click(object sender, EventArgs e)
        {
            StokTakip takip = new StokTakip();
            takip.Show();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            EntityByAdded added = new EntityByAdded(txtUrun.Text);
            BilgiGetir();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            BilgiGetir();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            //TODO: Kullanıcı ID'yi nerden bilsin, niye yazsın?! Seç düzenle gibi bir şey yapmak gerekir.
            EntityByUpdated updated = new EntityByUpdated(Convert.ToInt32(txtid.Text), txtUrun.Text);
            BilgiGetir();
        }

        
        private void btnSil_Click(object sender, EventArgs e)
        {
            //TODO: Kullanıcı ID'yi nerden bilsin, niye yazsın?! Seç düzenle gibi bir şey yapmak gerekir.
            EntityByDeleted deleted = new EntityByDeleted();
            deleted.EntityByDeletedCard(Convert.ToInt32(txtid.Text));
            BilgiGetir();
        }
    }
}
