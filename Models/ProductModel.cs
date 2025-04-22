using Microsoft.AspNetCore.Mvc;

namespace Products.Models
{
    //تعرف مجموعة List من نوع ProductModel داخل الدالة Index.
    public class ProductModel
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public float Price { get; set; }
        public string ImagePath { get; set; } = string.Empty; // مسار الصورة
    }
    /*
    public class ProductDetailsModel
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public float Price { get; set; }
        public string Description { get; set; } = string.Empty;
    }
    */
}
