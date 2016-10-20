using Shop.DataLayer.DbLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Data.Entity;
using Shop.DataLayer.BusinessLayer;
using System.Data.SqlClient;
using System.Drawing.Drawing2D;


namespace Shop.WinForm
{
    public partial class Form1 : Form
    {
        ShopContext context;//= new ShopContext();


        BindingSource bsCategory = new BindingSource();
        BindingSource bsGood = new BindingSource();

        public Form1(string ConnectionString)
        {
            InitializeComponent();
            context = new ShopContext(ConnectionString);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            context.Categories.Load();
            context.Goods.Load();
            context.Manufacturers.Load();
            context.Photos.Load();


            bsCategory.DataSource = context.Categories.Local;
            lbCategory.DisplayMember = "CategoryName";
            lbCategory.ValueMember = "CategoryId";
            lbCategory.DataSource = bsCategory;

            int CategoryId =   Convert.ToInt32(lbCategory.SelectedValue);

            GetGoodsByCategory(CategoryId);



        }

        private void GetGoodsByCategory(int CategoryId)
        {
            bsGood.DataSource = context.Goods.Local.Where(g => g.CategoryId == CategoryId);
            lbGood.DisplayMember = "GoodName";
            lbGood.ValueMember = "GoodId";
            lbGood.DataSource = bsGood;
            
            int count =context.Goods.Local.Where(g => g.CategoryId == CategoryId).Count();
            gBoxListGood.Visible = (count > 0);
            gBoxGood.Visible = (count > 0);
            btnAddCart.Visible = (count > 0);
        }

        private void lbCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            int CategoryId = Convert.ToInt32(lbCategory.SelectedValue);

            GetGoodsByCategory(CategoryId);
            if (context.Goods.Local.Where(g => g.CategoryId == CategoryId).Count() > 0)
            {
                int GoodId = Convert.ToInt32(lbGood.SelectedValue);
                GetGoodShow(GoodId);
            }
        }


        private GoodInfo GetGoodInfo(int GoodId)
        {

            //SqlParameter parameter = new SqlParameter("@GoodId", GoodId);

            //var query = context.Database.SqlQuery<GoodInfo>(@"SELECT TOP 1  g.GoodId, g.GoodName, 
            //                 CASE
            //            WHEN m.ManufacturerName IS NULL THEN 'Не задано'
            //            ELSE m.ManufacturerName
            //           END ManufacturerName
            //           ,
            //           g.Price, g.GoodCount,
            //           CASE
            //            WHEN  p.PhotoPath IS NULL THEN 'Images\notphoto.png'
            //            ELSE  p.PhotoPath
            //           END PhotoPath
            //                FROM dbo.Good g LEFT JOIN dbo.Manufacturer m ON g.ManufacturerId=m.ManufacturerId
            //                     LEFT JOIN dbo.Photo p ON(g.GoodId=p.GoodId)

            //                WHERE g.GoodId = @GoodId ", parameter);

            var goods = context.Goods.Local.Where(g => g.GoodId == GoodId);
            var manuf = context.Manufacturers.Local;
            var photo = context.Photos.Local;


            var qry = from g in goods
                      join m in manuf on g.ManufacturerId equals m.ManufacturerId into mgrp
                      from mg in mgrp.DefaultIfEmpty(new Manufacturer() { ManufacturerId = 0, ManufacturerName = "Не задан произв." })
                      select new
                      {
                          g.GoodId,
                          g.GoodName,
                          mg.ManufacturerName,
                          g.Price,
                          g.GoodCount
                      };
            var query = from g in qry
                        join p in photo on g.GoodId equals p.GoodId into photogrp
                        from ph in photogrp.DefaultIfEmpty(new Photo() { PhotoId = 0, GoodId = g.GoodId, PhotoPath = "Images\\notphoto.png" })

                        select new GoodInfo()
                        {
                            GoodId = g.GoodId,
                            GoodName = g.GoodName,
                            ManufacturerName = g.ManufacturerName,
                            Price = g.Price,
                            GoodCount = g.GoodCount,
                            PhotoPath = ph.PhotoPath
                        };

            GoodInfo tmp = query.FirstOrDefault();
            return tmp;
        }

        private void lbGood_SelectedIndexChanged(object sender, EventArgs e)
        {
            int GoodId = Convert.ToInt32(lbGood.SelectedValue);

            GetGoodShow(GoodId);
          
        }

        private void GetGoodShow(int GoodId)
        {
            GoodInfo good = GetGoodInfo(GoodId);
            lblNameGood.Text = good.GoodName;
            lblMaunufacturer.Text = good.ManufacturerName;
            lblPrice.Text = good.Price.ToString();
            lblCount.Text = good.GoodCount.ToString();

            Image img = Image.FromFile(good.PhotoPath);

            pictureGood.Image = ResizeImage.FixedSize(img, pictureGood.Width, pictureGood.Height, true); ;
        }




    }
}
