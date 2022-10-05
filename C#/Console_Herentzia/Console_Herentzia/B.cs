﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_Herentzia
{
    internal class B : A
    {
        public string Prop3 { get; set; }

        public override string Prop2
        {
            get => base.Prop2;

            set
            {
                if (value.Length < 8)
                {
                    Exception ex = new Exception("Ez da zuzena, 8 karaktere gutxienez.");
                    throw ex;
                }
                else { base.Prop2 = value; }

            }
        }
    

    public override void Erakutsi()
    {
        Console.WriteLine("B klasea");
        Console.WriteLine("{0}, {1}, {2}", Prop1, Prop2, Prop3);
    }
}}
