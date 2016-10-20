using Shop.DataLayer.DbLayer;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.LinqLeftJoin3Entity
{
    class Program
    {
        static void Main(string[] args)
        {
            ShopContext context = new ShopContext();
            //context.Categories.Load();
            context.Goods.Load();
            context.Manufacturers.Load();
            context.Photos.Load();


            var goods = context.Goods.Local.Where(g => g.CategoryId == 2);
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
                        
                        select new
                        {
                            g.GoodId,
                            g.GoodName,
                            g.ManufacturerName,
                            g.Price,
                            g.GoodCount,
                            ph.PhotoPath
                        };
            foreach (var item in query)
            {
                Console.WriteLine("{0, -40}  \t{1, -20} \t{2}" , item.GoodName, item.ManufacturerName, item.PhotoPath);
            }

        }
    }
}
