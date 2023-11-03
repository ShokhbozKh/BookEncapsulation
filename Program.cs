namespace ConsoleApp4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Quyidagi propertylardan iborat Book klassini encapsulation prinsipi asosida yarating: nomi,
            //avtorlari (bir nechta bo’lishi mumkin), ISBN(13 ta sondan iborat xalqaro kitob raqami,
            //masalan 012345689112) va narxi. Kitob nomi va avtorlarini chop etuvchi method yarating. 
            Book book1 = new("Odam Bulish qiyin");
            book1.ISBN = 1231212323454123;
            book1.Narxi = 123_123_98;
            book1.Avtorlari = new()
            {
                "Ulmas Umarbekov",
                
            };
            Console.WriteLine("---------1--------------");
            book1.GetBookInfo();
            
            Book book2 = new("Ulsang kim yig'laydi");
            book2.ISBN =1234567890123;
            book2.Narxi = 123_098;
            book2.Avtorlari = new()
            {
                "Robin Sharma",
                "Jeck Ma",
                "Brus Lee"
            };
            Console.WriteLine("---------2--------------");
            book2.GetBookInfo();


        }
    }
    class Book
    {
        public string Nomi { get; private set; }
        public List<string> Avtorlari { get; set; }

        private ulong isbn; // 13 ta raqamlik
        private decimal narxi;
        public ulong ISBN
        {
            get { return isbn; }
            set
            {
                if(value.ToString().Length == 13)
                {
                    isbn = value;
                }
                else
                {
                    return;
                }
            }
        }
        public decimal Narxi
        {
            get { return narxi; }
            set
            {
                narxi = value;
            }

        }
        public Book(string name)
        {
            Nomi = name;
        }
        public void GetBookInfo()
        {
            Console.WriteLine($"Kitob nomi:{Nomi}");
            int t = 0;
            Console.WriteLine($"----------Avtorlari------------");
            foreach( var item in Avtorlari )
            { 
                Console.WriteLine($"{++t}: {item}"); 
            }
            
            Console.WriteLine($"Narxi:{narxi}");
            Console.WriteLine($"Raqami:{isbn}");

        }
    }
}