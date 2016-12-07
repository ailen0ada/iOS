﻿using System;
using UIKit;
namespace XiOS_App01.Models
{
    public class TableItem
    {
        public string Name { get; private set; }
        public string Title { get; private set; }
        public UIImage Image { get; set; }

        public TableItem(string name, string title, UIImage image)
        {
            this.Name = name;
            this.Title = title;
            this.Image = image;
        }
    }
}
