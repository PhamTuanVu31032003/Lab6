internal class Program
{
    private static void Main(string[] args)
    {
       int chuc = 0; 
        int donvi = 0;
        int tram = 0;
        Console.WriteLine("Nhap mot so");
        int so = int.Parse(Console.ReadLine());
        if (0<=so&&so<999){
            if(0<=so&&so<10){
              if(so==0) Console.WriteLine(" khong");
              else if   (so==1) Console.WriteLine(" mot");
              else if   (so==2) Console.WriteLine(" hai");
              else if   (so==3) Console.WriteLine(" ba");
              else if   (so==4) Console.WriteLine(" bon");
              else if   (so==5) Console.WriteLine(" nam");
              else if   (so==6) Console.WriteLine(" sau");
              else if   (so==7) Console.WriteLine(" bay");
              else if   (so==8) Console.WriteLine(" tam");
              else Console.WriteLine("in ra chin");
            }
        else if(10<=so&&so<99){
            chuc = so/10; // lấy hàng chục
            donvi = so%10; // lấy hàng đơn vị
             if (chuc == 1) Console.Write("mười");
                else if (chuc == 2) Console.Write("hai mươi");
                else if (chuc == 3) Console.Write("ba mươi");
                else if (chuc == 4) Console.Write("bốn mươi");
                else if (chuc == 5) Console.Write("năm mươi");
                else if (chuc == 6) Console.Write("sáu mươi");
                else if (chuc == 7) Console.Write("bảy mươi");
                else if (chuc == 8) Console.Write("tám mươi");
              else Console.WriteLine("chín mươi");
              if(donvi==0) Console.WriteLine(" không");
             else if  (donvi==1) Console.Write(" một");
              else if   (donvi==2) Console.Write(" hai");
              else if   (donvi==3) Console.Write(" ba");
              else if   (donvi==4) Console.Write(" bốn");
              else if   (donvi==5) Console.Write(" năm");
              else if   (donvi==6) Console.Write(" sáu");
              else if   (donvi==7) Console.Write(" bảy");
              else if   (donvi==8) Console.Write(" tám");
              else Console.WriteLine("chín");
        }
        else if(100<=so&&so<999){
                tram = so / 100; // lấy hàng trăm
                chuc = (so / 10) % 10; // lấy hàng chục
                donvi = so % 10; // lấy hàng đơn vị

            if (tram == 1) Console.Write("một trăm");
                else if (tram == 2) Console.Write("hai trăm");
                else if (tram == 3) Console.Write("ba trăm");
                else if (tram == 4) Console.Write("bốn trăm");
                else if (tram == 5) Console.Write("năm trăm");
                else if (tram == 6) Console.Write("sáu trăm");
                else if (tram == 7) Console.Write("bảy trăm");
                else if (tram == 8) Console.Write("tám trăm");
                else if (tram == 9) Console.Write("chín trăm");
                 if (chuc == 1) Console.Write("mười");
                else if (chuc == 2) Console.Write("hai mươi");
                else if (chuc == 3) Console.Write("ba mươi");
                else if (chuc == 4) Console.Write("bốn mươi");
                else if (chuc == 5) Console.Write("năm mươi");
                else if (chuc == 6) Console.Write("sáu mươi");
                else if (chuc == 7) Console.Write("bảy mươi");
                else if (chuc == 8) Console.Write("tám mươi");
              else Console.WriteLine("chín mươi");
              if(donvi==0) Console.WriteLine(" không");
             else if  (donvi==1) Console.Write(" một");
              else if   (donvi==2) Console.Write(" hai");
              else if   (donvi==3) Console.Write(" ba");
              else if   (donvi==4) Console.Write(" bốn");
              else if   (donvi==5) Console.Write(" năm");
              else if   (donvi==6) Console.Write(" sáu");
              else if   (donvi==7) Console.Write(" bảy");
              else if   (donvi==8) Console.Write(" tám");
              else Console.WriteLine("chín");
            
        }
        }
        else{
            Console.WriteLine("nhap sai gia tri");
        }
    }
}

    
