﻿using Oop.Tuan.Base;
using Oop.Tuan.Dao;
using Oop.Tuan.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oop.Tuan.Demo
{
    public class CategoryDaoDemo
    {
        public void InsertCategoryTest(BaseRow obj)
        {
            Database.GetInstance().InsertTable(obj);
        }

        public void SelectCategoryTest(string productName)
        {
            Database.GetInstance().SelectTable(productName);
        }

        public void UpdateCategoryTest(BaseRow obj, int id)
        {
            Database.GetInstance().UpdateTable(obj, id);
        }

        public void FindCategoryTest(string productName)
        {
            Database.GetInstance().PrintInforTable(productName);
        }
    }
}
