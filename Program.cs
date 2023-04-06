using tugas_pbo_praktikum;

namespace tugas_pbo_praktikum
{
    public class Processor
    {
        public string merk, tipe;
    }

    public class Intel : Processor
    {
        public Intel()
        {
            base.merk = "Intel";
        }
    }
    class CoreI3 : Intel
    {
        public CoreI3()
        {
            base.tipe = "Core i3";
        }
    }
    class CoreI5 : Intel
    {
        public CoreI5()
        {
            base.tipe = "Core i5";
        }
    }
    class CoreI7 : Intel
    {
        public CoreI7()
        {
            base.tipe = "Core i7";
        }
    }
    public class amd : Processor
    {
        public amd()
        {
            base.merk = "AMD";
        }
    }
    class Athlon : Processor
    {
        public Athlon()
        {
            base.tipe = "ATHLON";
        }
    }
    class Ryzen : amd
    {
        public Ryzen()
        {
            base.tipe = "RAYZEN";
        }
    }

    public class Vga
    {
        public string merk;
    }
    class Nvidia : Vga
    {
        public Nvidia()
        {
            base.merk = "Nvidia";
        }
    }
    class AMD: Vga
    {
        public AMD()
        {
            base.merk = "AMD";
        }
    }

    public class Laptop
    {
        public string merk, tipe;
        public Vga vga;
        public Processor processor;

        public void LaptopDinyalakan()
        {
            Console.WriteLine($"Laptop {merk} {tipe} menyala");
        }
        public void LaptopDimatikan()
        {
            Console.WriteLine($"Laptop {merk} {tipe} dimatikan");
        }
    }
    public class Lenovo : Laptop
    {
        public Lenovo()
        {
            base.merk = "Lenovo";
        }
    }
    class Legion : Lenovo
    {
        public Legion()
        {
            base.tipe = "Legion";
        }
    }
    class IdeaPad : Lenovo
    {
        public IdeaPad()
        {
            base.tipe = "IdeaPad";
        }
    }

    public class ASUS : Laptop
    {
        public ASUS()
        {
            base.merk = "ASUS";
        }
    }
    class Vivobook : ASUS
    {
        public Vivobook()
        {
            base.tipe = "Vivobook";
        }
        public void Ngoding()
        {
            Console.WriteLine("Ctak Ctak Ctak, error lagi!!");
        }
    }
    class ROG : ASUS
    {
        public ROG()
        {
            base.tipe = "ROG";
        }
    }
    public class ACER : Laptop
    {
        public ACER()
        {
            base.merk = "ACER";
        }
    }
    class Swift : ACER
    {
        public Swift()
        {
            base.tipe = "Swift";
        }
    }
    class Predator : ACER
    {
        public Predator()
        {
            base.tipe = "Predator";
        }
        public void BermainGame()
        {
            Console.WriteLine($"Laptop {merk} {tipe} sedang memainkan game");
        }
    }
}
internal class program
{
    static void Main(string[]args)
    {
        Laptop laptop1 = new Vivobook();
        laptop1.vga = new Nvidia();
        laptop1.processor = new CoreI5();

        Console.WriteLine(laptop1.vga.merk);
        Console.WriteLine(laptop1.processor.merk);
        Console.WriteLine(laptop1.processor.tipe);
        Console.WriteLine(" ");

        //laptop1.Ngoding();

        Laptop laptop2 = new IdeaPad();
        laptop2.vga = new AMD();
        laptop2.processor = new Ryzen();

        Console.WriteLine(laptop2.vga.merk);
        Console.WriteLine(laptop2.processor.merk);
        Console.WriteLine(laptop2.processor.tipe);
        Console.WriteLine(" ");

        Predator predator = new Predator();
        predator.vga = new AMD();
        predator.processor = new CoreI7();

        Console.WriteLine(predator.vga.merk);
        Console.WriteLine(predator.processor.merk);
        Console.WriteLine(predator.processor.tipe);

        predator.BermainGame();
    }
}