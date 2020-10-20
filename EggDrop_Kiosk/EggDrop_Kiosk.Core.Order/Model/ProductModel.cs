﻿using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EggDrop_Kiosk.Core.Order.Model
{
    public class ProductModel: BindableBase
    {
        private int _idx;
        public int Idx
        {
            get => _idx;
            set => SetProperty(ref _idx, value);
        }

        private string _name;
        public string Name
        {
            get => _name;
            set => SetProperty(ref _name, value);
        }

        private string _imagePath;
        public string ImagePath
        {
            get => _imagePath;
            set => SetProperty(ref _imagePath, value);
        }

        private int _categoryIdx;
        public int CategoryIdx
        {
            get => _categoryIdx;
            set => SetProperty(ref _categoryIdx, value);
        }

        private int _price;
        public int Price
        {
            get => _price;
            set => SetProperty(ref _price, value);
        }


        private int _salePercent;
        public int SalePercent
        {
            get => _salePercent;
            set
            {
                SetProperty(ref _salePercent, value);
                _salePrice = Price - (SalePercent / 100 * Price);
            }
        }

        private int _salePrice;
        public int SalePrice
        {
            get => _salePrice;
            set => SetProperty(ref _salePrice, value);
        }

        private int _count;
        public int Count
        {
            get => _count;
            set => SetProperty(ref _count, value);
        }

        private int _page;
        public int Page
        {
            get => _page;
            set => SetProperty(ref _page, value);
        }
    }
}
