﻿namespace L4_Partial_OperOverloading

{
    abstract partial class PartialTriangle
    {
        public  partial void GetPerimetr()
        {
            Console.WriteLine("gdfgd");
        }
        //{
        //    Console.WriteLine("dfgdfg");
        //}
    }

    partial class PartialTriangle
    {
        public partial void GetPerimetr();
        //{
        //    Console.WriteLine("dfgdf");
        //}
        //public partial void GetPerimetr();
        //{
        //    Console.WriteLine("gdfgd");
        //}

        //{
        //    Console.WriteLine("gdfgd");
        //}
    }
}
