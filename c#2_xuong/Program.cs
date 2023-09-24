namespace c_2_xuong
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            int key;
            SERVICE sERVICE = new SERVICE();
            do
            {
                
                Console.WriteLine("Menu:");
                Console.WriteLine("1.Nhập danh sách đối tượng");
                Console.WriteLine("2.Xuất danh sách đối tượng");
                Console.WriteLine("3.Lưu File - Đọc File");
                Console.WriteLine("4.Xóa đối tượng theo ID sử dụng LINQ");
                Console.WriteLine("5.Thoát");
                Console.WriteLine("Mời chọn");
                key =Convert.ToInt32(Console.ReadLine());
                switch (key)
                {
                    case 1:
                        sERVICE.Inp();
                        break;
                    case 2:
                        sERVICE.Outp();
                        break;
                    case 3:
                        sERVICE.Filee();
                        break;
                    case 4:
                        sERVICE.Dele();
                        break;
                    case 5:
                        Console.WriteLine("Thoát");
                        Environment.Exit(0);
                        break;
                    default:
                        break;
                }
            }while (key!=6);
        }
    }
}