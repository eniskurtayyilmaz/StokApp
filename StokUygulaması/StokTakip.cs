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
            EntityByAdded added = new EntityByAdded(Convert.ToInt32(txtid.Text), Convert.ToInt32(txtAdet.Text), Convert.ToInt32(textBox1.Text));
            BilgiGetir();
        }

        private void StokTakip_Load(object sender, EventArgs e)
        {
            BilgiGetir();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            EntityByDeleted deleted = new EntityByDeleted();
            deleted.EntityByDeletedMovements(Convert.ToInt32(txtid.Text));
            BilgiGetir();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            EntityByUpdated updated = new EntityByUpdated(Convert.ToInt32(txtid.Text), Convert.ToInt32(txtAdet.Text), Convert.ToInt32(textBox1.Text));
            BilgiGetir();
        }
    }
}
