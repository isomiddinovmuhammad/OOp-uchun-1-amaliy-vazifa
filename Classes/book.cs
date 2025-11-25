namespace KESCHA.Classes;

using System;

class Book
{
    // ===== PRIVATE FIELDLAR =====
    private string _name;
    private string _author;
    private double _price;

    // ===== PROPERTYLAR =====
    public string Name
    {
        get { return _name; }
    }

    public string Author
    {
        get { return _author; }
        set { _author = value; }
    }

    public double Price
    {
        get { return _price; }
        set
        {
            if (value > 0)
                _price = value;
            else
                Console.WriteLine("Narx manfiy bo‘lishi mumkin emas!");
        }
    }

    // ===== CONSTRUCTOR =====
    public Book(string name)
    {
        _name = name;
    }

    // ===== Qo‘shimcha xususiyat =====
    public int Pages { get; set; }

    // ===== METHODLAR =====
    public void ShowInfo()
    {
        Console.WriteLine("=== Kitob ma'lumotlari ===");
        Console.WriteLine($"Nomi:   {_name}");
        Console.WriteLine($"Muallifi: {Author}");
        Console.WriteLine($"Narxi:  {Price}");
        Console.WriteLine($"Sahifalar: {Pages}");
    }
}

class Program
{
    static void Main()
    {
        // ==== Book class dan object yaratish ====
        Book b1 = new Book("O'tkan kunlar");

        // Propertylar orqali qiymatlarni o‘zgartirish
        b1.Author = "Abdulla Qodiriy";
        b1.Price = 45000;
        b1.Pages = 320;

        // Method yordamida ko‘rsatish
        b1.ShowInfo();

        // Qiymat o‘zgartirish
        b1.Price = 50000;
        Console.WriteLine("\nNarx o'zgartirildi!");
        b1.ShowInfo();
    }
}
