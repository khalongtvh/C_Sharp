using System;

namespace BaiTap_If_Else
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bai 1: Kiem tra so duong - am");
            Console.WriteLine("Bai 2: Chuyen doi so thanh chu");
            Console.WriteLine("Bai 3: Kiem tra 3 canh tam giac");
            Console.WriteLine("Bai 4: Kiem tra 3 canh tam giac vuong");
            Console.WriteLine("----------------------------------------------------------------------------------------------------------------------------\n \n");
            Console.Write("Nhap ten bai(1-4) : ");
            int choose = int.Parse(Console.ReadLine());


            if (choose == 1)
            {
                int n_229;
                bool isSuccess_229;
                Console.Write("Nhap so nguyen duong : ");
                string str_229 = Console.ReadLine();
                isSuccess_229 = int.TryParse(str_229, out n_229);
                if (isSuccess_229)
                {
                    if (n_229 >= 0)
                    {
                        Console.WriteLine("Day la so nguyen duong!");
                    }
                    else
                    {
                        Console.WriteLine("Day la so nguyen am!");
                    }
                }
                else
                {
                    Console.WriteLine(str_229 + " Khong phai so nguyen");
                }
            } 
            else if(choose == 2)
                {
                    int n_229;
                    bool isSuccess_229;
                    Console.Write("Nhap vao mot so nguyen(0-9) : ");
                    string str_229 = Console.ReadLine();
                    isSuccess_229 = int.TryParse(str_229, out n_229);
                    if (isSuccess_229)
                    {
                        if (n_229 == 0)
                            Console.WriteLine("khong");
                        else if (n_229 == 1)
                            Console.WriteLine("mot");
                        else if (n_229 == 2)
                            Console.WriteLine("hai");
                        else if (n_229 == 3)
                            Console.WriteLine("ba");
                        else if (n_229 == 4)
                            Console.WriteLine("bon");
                        else if (n_229 == 5)
                            Console.WriteLine("nam");
                        else if (n_229 == 6)
                            Console.WriteLine("sau");
                        else if (n_229 == 7)
                            Console.WriteLine("bay");
                        else if (n_229 == 8)
                            Console.WriteLine("tam");
                        else if (n_229 == 9)
                            Console.WriteLine("chin");
                        else
                            Console.WriteLine("khong the doc so");
                    }
                    else
                    {
                        Console.WriteLine(str_229 + " Khong phai so nguyen!");
                    }
                } 
            else if (choose == 3 || choose == 4)
                    {
                        double a_229, b_229, c_229;
                        Console.WriteLine("Nhap 3 so thuc : ");
                        a_229 = Double.Parse(Console.ReadLine());
                        b_229 = Double.Parse(Console.ReadLine());
                        c_229 = Double.Parse(Console.ReadLine());
                        if(choose == 3)
                        {
                            if (a_229 + b_229 > c_229 && b_229 + c_229 > a_229 && c_229 + a_229 > b_229)
                                Console.WriteLine("{0}, {1}, {2} la 3 canh cua tam giac", a_229, b_229, c_229);
                            else
                                Console.WriteLine("{0}, {1}, {2} khong phai la 3 canh cua tam giac", a_229, b_229, c_229);
                        } else if(choose == 4)
                            {
                                if (a_229 * a_229 + b_229 * b_229 == c_229 * c_229 || b_229 * b_229 + c_229 * c_229 == a_229 * a_229 || c_229 * c_229 + a_229 * a_229 == b_229 * b_229)
                                    Console.WriteLine("{0}, {1}, {2} la 3 canh cua tam giac vuong", a_229, b_229, c_229);
                                else
                                    Console.WriteLine("{0}, {1}, {2} khong phai la 3 canh cua tam giac vuong", a_229, b_229, c_229);
                            }
                        
                    }
            else
            {
                Console.WriteLine("Thoat chuong trinh");
            }
        }
    }
}
