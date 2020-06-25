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
    public partial class StokKartı : Form
    {
        public StokKartı()
        {
            InitializeComponent();
        }
        public void BilgiGetir()
        {
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
            EntityByUpdated updated = new EntityByUpdated(Convert.ToInt32(txtid.Text), txtUrun.Text);
            BilgiGetir();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            EntityByDeleted deleted = new EntityByDeleted();
            deleted.EntityByDeletedCard(Convert.ToInt32(txtid.Text));
            BilgiGetir();
        }
    }
}
