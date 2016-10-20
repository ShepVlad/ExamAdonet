using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Shop.DataLayer.DbLayer;

using System.Data.Entity;
using System.IO;

namespace Shop.WinForm
{
    public partial class FrmEditPhoto : Form
    {
        ShopContext context = new ShopContext();
        BindingSource bsGood = new BindingSource();
        public FrmEditPhoto()
        {
            InitializeComponent();
        }

        private void FrmEditPhoto_Load(object sender, EventArgs e)
        {
            context.Goods.Load();
            context.Photos.Load();

            bsGood.DataSource = context.Goods.Local;
            dgvGood.DataSource = bsGood;

        }

        private void btnAddPhoto_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();

            open.Filter = "All Files(*.*)|*.*";
            if (open.ShowDialog() == DialogResult.OK)
            {
                string result = Path.GetFileName(open.FileName);
                string ext = Path.GetExtension(open.FileName);
                string fullpath = Path.Combine("Images", Guid.NewGuid().ToString() + "." + ext);

                File.Copy(open.FileName, fullpath);

                Image img = Image.FromFile(fullpath);
                PictureBox p = new PictureBox();
                p.Width = 110;
                p.Height = 120;
              

                p.Image = ResizeImage.FixedSize(img, p.Width, p.Height, true); 
               
                flowPanelPhoto.Controls.Add(p);

                context.Photos.Local.Add(new Photo()
                {
                    GoodId = (bsGood.Current as Good).GoodId,
                    PhotoPath = fullpath
                });

            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            context.SaveChanges();
        }

        private void dgvGood_SelectionChanged(object sender, EventArgs e)
        {
            flowPanelPhoto.Controls.Clear();
            flowPanelPhoto.Update();

            var list = context.Photos.
                Local.Where(g => g.GoodId == (bsGood.Current as Good).GoodId)
                .ToList();
            foreach (var item in list)
            {
                Image img = Image.FromFile(item.PhotoPath);
                PictureBox p = new PictureBox();
                p.Width = 110;
                p.Height = 120;


                p.Image = ResizeImage.FixedSize(img, p.Width, p.Height, true);

                flowPanelPhoto.Controls.Add(p);
            }

        }
    }
}
