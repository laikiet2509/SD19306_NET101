﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8_OOP_4TinhChat
{
    /*
     *  Tính bao đóng (đóng gói) là tính chất thể hiện khả năng truy cập
     *  đến các thành phần trong class bao gồm (thuộc tính, constructor,
     *  property, phương thức(method))
     *  Tính đóng gói được thể hiện thông qua các access modfier bao gồm:
     *  private (mặc định):  Chỉ có thể truy cập trong class chứa nó
     *  public: Truy cập được ở mọi nơi
     *  protected: Truy cập được ở chính nó và class kế thừa từ nó
     *  internal: Truy cập được mọi nơi trong phạm vi asembly (project)
     *  protected internal: protected + internal: Hoặc là trong class con
     *  hoặc là trong cùng 1 project 
     */
    public class Oto
    {
        private string ten = "Mercedes S680";
        public string hangSX = "Mercedes";
        protected int namSX = 2024;
        internal string color = "GoldenBlack";
        protected internal int soghe = 5;
        public Oto()
        {

        }
    }
}
