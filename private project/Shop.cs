using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace private_project
{
    public class Shop : item
    {
        List<item> items = new List<item>();
        public void InitializeItem()
        {
            item item1 = new item();
            item1.InitialItem("돌창", 50, 20, "정예전사에게만 주어지는 날카로운 돌창이다.");
            items.Add(item1);

            item item2 = new item();
            item2.InitialItem("청동검", 100, 30, "과거 지도자들이 가지고다녔던 지배의 상징 청동검이다.");
            items.Add(item2);

            item item3 = new item();
            item3.InitialItem("Ak총", 150, 35, "폭풍속에서 잃어버린 현대기술의 소총이다.");
            items.Add(item3);

            item item4 = new item();
            item4.InitialItem("마취연막탄", 200, 40, "폭풍속에서 잃어버린 동물의 힘을 줄이기위해 특별히 제작된 마취연막탄이다.");
            items.Add(item4);

            item item5 = new item();
            item5.InitialItem("레이저건", 250, 50, "폭풍속에서 잃어버린 미래기술이 집약된 레이저건이다.");
            items.Add(item5);
        }
        public void firstscript()
        {
            Console.SetCursorPosition(4, 43);
            Console.Write("풀숲을 거니던 도중 부유해보이는 로봇을 발견했습니다.");
            Console.SetCursorPosition(4, 45);
            Console.Write("로봇은 잃어버렸던 무기를 포함해 다양한것들을 가지고있었습니다.");
            Console.SetCursorPosition(4, 47);
            Console.Write("안녕하십니까 휴먼? 저는 시공간 상인 T-360이라고 합니다.");
            Console.SetCursorPosition(4, 49);
            Console.Write("저의 물건을 보여드리겠습니다.");

        }
        public void PrintCursorPosition()
        {
            Console.SetCursorPosition(35, 7);
            Console.Write("▲");
            Console.SetCursorPosition(35, 9);
            Console.Write("▲");
            Console.SetCursorPosition(35, 11);
            Console.Write("▲");
            Console.SetCursorPosition(35, 13);
            Console.Write("▲");
            Console.SetCursorPosition(35, 15);
            Console.Write("▲");
            Console.SetCursorPosition(33, 7);
        }

        public void PrintShop()
        {
            Console.SetCursorPosition(7, 5);
            Console.Write("상점 인벤토리");
            Console.SetCursorPosition(7, 7);
            Console.Write("{0} : {1}", items[0].name, items[0].price);
            Console.SetCursorPosition(7, 9);
            Console.Write("{0} : {1}", items[1].name, items[1].price);
            Console.SetCursorPosition(7, 11);
            Console.Write("{0} : {1}", items[2].name, items[2].price);
            Console.SetCursorPosition(7, 13);
            Console.Write("{0} : {1}", items[3].name, items[3].price);
            Console.SetCursorPosition(7, 15);
            Console.Write("{0} : {1}", items[4].name, items[4].price);
        }
        public void PrintMerchant()
        {

            Console.SetCursorPosition(60, 5);
            Console.WriteLine("             ,--.    ,--.             ");
            Console.SetCursorPosition(60, 6);
            Console.WriteLine("            ((O ))--((O ))            ");
            Console.SetCursorPosition(60, 7);
            Console.WriteLine("          ,'_`--'____`--'_`.          ");
            Console.SetCursorPosition(60, 8);
            Console.WriteLine("         _:  ____________  :_         ");
            Console.SetCursorPosition(60, 9);
            Console.WriteLine("        | | ||::::::::::|| | |        ");
            Console.SetCursorPosition(60, 10);
            Console.WriteLine("        | | ||::::::::::|| | |        ");
            Console.SetCursorPosition(60, 11);
            Console.WriteLine("        | | ||::::::::::|| | |        ");
            Console.SetCursorPosition(60, 12);
            Console.WriteLine("        |_| |/__________\\| |_|        ");
            Console.SetCursorPosition(60, 13);
            Console.WriteLine("          |________________|          ");
            Console.SetCursorPosition(60, 14);
            Console.WriteLine("       __..-'            `-..__       ");
            Console.SetCursorPosition(60, 15);
            Console.WriteLine("    .-| : .----------------. : |-.    ");
            Console.SetCursorPosition(60, 16);
            Console.WriteLine("  ,\\ || | |\\______________/| | || /.  ");
            Console.SetCursorPosition(60, 17);
            Console.WriteLine(" /`.\\:| | ||  __  __  __  || | |;/,'\\ ");
            Console.SetCursorPosition(60, 18);
            Console.WriteLine(":`-._\\;.| || '--''--''--' || |,:/_.-':");
            Console.SetCursorPosition(60, 19);
            Console.WriteLine("|    :  | || .----------. || |  :    |");
            Console.SetCursorPosition(60, 20);
            Console.WriteLine("|    |  | || '----SSt---' || |  |    |");
            Console.SetCursorPosition(60, 21);
            Console.WriteLine("|    |  | ||   _   _   _  || |  |    |");
            Console.SetCursorPosition(60, 22);
            Console.WriteLine(":,--.;  | ||  (_) (_) (_) || |  :,--.;");
            Console.SetCursorPosition(60, 23);
            Console.WriteLine("(`-'|)  | ||______________|| |  (|`-')");
            Console.SetCursorPosition(60, 24);
            Console.WriteLine(" `--'   | |/______________\\| |   `--' ");
            Console.SetCursorPosition(60, 25);
            Console.WriteLine("        |____________________|        ");
            Console.SetCursorPosition(60, 26);
            Console.WriteLine("         `.________________,'         ");
            Console.SetCursorPosition(60, 27);
            Console.WriteLine("          (_______)(_______)          ");
            Console.SetCursorPosition(60, 28);
            Console.WriteLine("          (_______)(_______)          ");
            Console.SetCursorPosition(60, 29);
            Console.WriteLine("          (_______)(_______)          ");
            Console.SetCursorPosition(60, 30);
            Console.WriteLine("          (_______)(_______)          ");
            Console.SetCursorPosition(60, 31);
            Console.WriteLine("         |        ||        |         ");
            Console.SetCursorPosition(60, 32);
            Console.WriteLine("         '--------''--------'         ");
        }

        public void Buy(UI UI1,Player albert)
        {
            bool buyCheck = false;
            bool closeShop = false;
            PrintMerchant();
            Console.SetCursorPosition(33,7);
            while (true)
            {
                ConsoleKeyInfo input = Console.ReadKey();
                switch (input.Key)
                {
                    case ConsoleKey.UpArrow:
                        if (Console.CursorTop == 7)
                        {
                            Console.SetCursorPosition(33, 15);
                        }
                        else
                        {
                            Console.SetCursorPosition(33, Console.CursorTop - 2);
                        }
                        break;
                    case ConsoleKey.DownArrow:
                        if (Console.CursorTop == 15)
                        {
                            Console.SetCursorPosition(33, 7);
                        }
                        else
                        {
                            Console.SetCursorPosition(33, Console.CursorTop + 2);
                        }
                        break;
                    case ConsoleKey.Enter:
                        switch (Console.CursorTop)
                        {
                            case 7:
                                {
                                    Console.Clear();
                                    UI1.MakeUI();
                                    PrintMerchant();
                                    PrintShop();
                                    PrintCursorPosition();
                                    UI1.Printstate(albert);
                                    
                                    Console.SetCursorPosition(4, 43);
                                    Console.Write("돌창을 구매하시겠습니까?");
                                    Console.SetCursorPosition(10, 45);
                                    Console.Write("네");
                                    Console.SetCursorPosition(10, 47);
                                    Console.Write("아니오");
                                    Console.SetCursorPosition(10, 46);
                                    while (true)
                                    {
                                        ConsoleKeyInfo input2 = Console.ReadKey();
                                        switch (input2.Key)
                                        {
                                            case ConsoleKey.UpArrow:
                                                if(Console.CursorTop == 46)
                                                {
                                                    Console.SetCursorPosition(10, 48);
                                                    break;
                                                }
                                                else if( Console.CursorTop == 48)
                                                {
                                                    Console.SetCursorPosition(10, 46);
                                                    break;
                                                }
                                                break;
                                            case ConsoleKey.DownArrow:
                                                if(Console.CursorTop == 46)
                                                {
                                                    Console.SetCursorPosition(10, 48);
                                                    break;
                                                }
                                                else if( Console.CursorTop ==48)
                                                {
                                                    Console.SetCursorPosition(10, 46);
                                                    break;
                                                }
                                                break;
                                            case ConsoleKey.Enter: 
                                                if (Console.CursorTop == 46)
                                                {
                                                    Console.Clear();
                                                    UI1.MakeUI();
                                                    PrintMerchant();
                                                    PrintShop();
                                                    PrintCursorPosition();
                                                    UI1.Printstate(albert);
                                                    
                                                    if (albert.fossils >= items[0].price)
                                                    {
                                                        Console.SetCursorPosition(4, 43);
                                                        Console.Write("휴먼! 탁월한선택입니다.!");
                                                        Console.SetCursorPosition(4, 45);
                                                        Console.Write("아이템구매에 성공했습니다!");
                                                        albert.fossils = items[0].price;
                                                        albert.weaponPower = items[0].power;
                                                        albert.weaponName = items[0].name;
                                                        Task.Delay(1000).Wait();
                                                        Console.SetCursorPosition(33, 7);
                                                        buyCheck = true;
                                                        break;
                                                    }
                                                    else
                                                    {
                                                        Console.Clear();
                                                        UI1.MakeUI();
                                                        PrintMerchant();
                                                        PrintShop();
                                                        PrintCursorPosition();
                                                        UI1.Printstate(albert);
                                                        Console.SetCursorPosition(4, 43);
                                                        Console.Write("그 물건은 당신이 다루기 어려울것입니다.");
                                                        Console.SetCursorPosition(4, 45);
                                                        Console.Write("화석이 부족합니다.");
                                                        Task.Delay(1000).Wait();
                                                        Console.SetCursorPosition(33, 7);
                                                        buyCheck = true;
                                                       
                                                    }
                                                }
                                                else if (Console.CursorTop == 48)
                                                {
                                                    Console.Clear();
                                                    UI1.MakeUI();
                                                    PrintMerchant();
                                                    PrintShop();
                                                    PrintCursorPosition();
                                                    UI1.Printstate(albert);
                                                    Console.SetCursorPosition(4, 43);
                                                    Console.Write("다른물건도 있으니 구경부탁드립니다 휴먼.");
                                                    Task.Delay(1000).Wait();
                                                    Console.SetCursorPosition(33, 7);
                                                    buyCheck = true;
                                                    break;
                                                }
                                                break;
                                        }
                                        if (buyCheck == true)
                                        {
                                            buyCheck = false;
                                            break;
                                        }
                                    }
                                    break;
                                }
                            case 9:
                                {
                                    Console.Clear();
                                    UI1.MakeUI();
                                    PrintMerchant();
                                    PrintShop();
                                    PrintCursorPosition();
                                    UI1.Printstate(albert);
                                    Console.SetCursorPosition(4, 43);
                                    Console.Write("청동검을 구매하시겠습니까?");
                                    Console.SetCursorPosition(10, 45);
                                    Console.Write("네");
                                    Console.SetCursorPosition(10, 47);
                                    Console.Write("아니오");
                                    Console.SetCursorPosition(10, 46);
                                    while (true)
                                    {
                                        ConsoleKeyInfo input2 = Console.ReadKey();
                                        switch (input2.Key)
                                        {
                                            case ConsoleKey.UpArrow:
                                                if (Console.CursorTop == 46)
                                                {
                                                    Console.SetCursorPosition(10, 48);
                                                    break;
                                                }
                                                else if (Console.CursorTop == 48)
                                                {
                                                    Console.SetCursorPosition(10, 46);
                                                    break;
                                                }
                                                break;
                                            case ConsoleKey.DownArrow:
                                                if (Console.CursorTop == 46)
                                                {
                                                    Console.SetCursorPosition(10, 48);
                                                    break;
                                                }
                                                else if (Console.CursorTop == 48)
                                                {
                                                    Console.SetCursorPosition(10, 46);
                                                    break;
                                                }
                                                break;
                                            case ConsoleKey.Enter:
                                                if (Console.CursorTop == 46)
                                                {
                                                    if (albert.fossils >= items[0].price)
                                                    {
                                                        Console.SetCursorPosition(4, 43);
                                                        Console.Write("휴먼! 탁월한선택입니다.!");
                                                        Console.SetCursorPosition(4, 45);
                                                        Console.Write("아이템구매에 성공했습니다!");
                                                        albert.fossils = items[1].price;
                                                        albert.weaponPower = items[1].power;
                                                        albert.weaponName = items[1].name;
                                                        Task.Delay(1000).Wait();
                                                        Console.SetCursorPosition(33, 7);
                                                        buyCheck = true;

                                                        break;
                                                    }
                                                    else
                                                    {
                                                        Console.Clear();
                                                        UI1.MakeUI();
                                                        PrintMerchant();
                                                        PrintShop();
                                                        PrintCursorPosition();
                                                        UI1.Printstate(albert);
                                                        Console.SetCursorPosition(4, 43);
                                                        Console.Write("그 물건은 당신이 다루기 어려울것입니다.");
                                                        Console.SetCursorPosition(4, 45);
                                                        Console.Write("화석이 부족합니다.");
                                                        Task.Delay(1000).Wait();
                                                        Console.SetCursorPosition(33, 7);
                                                        buyCheck = true;

                                                     
                                                    }
                                                }
                                                else if (Console.CursorTop == 48)
                                                {
                                                    Console.Clear();
                                                    UI1.MakeUI();
                                                    PrintMerchant();
                                                    PrintShop();
                                                    PrintCursorPosition();
                                                    UI1.Printstate(albert);
                                                    Console.SetCursorPosition(4, 43);
                                                    Console.Write("다른물건도 있으니 구경부탁드립니다 휴먼.");
                                                    Task.Delay(1000).Wait();
                                                    Console.SetCursorPosition(33, 7);
                                                    buyCheck = true;
                                                    break;
                                                }
                                                break;
                                        }
                                        if (buyCheck == true)
                                        {
                                            buyCheck = false;
                                            break;
                                        }
                                    }
                                    break;
                                }
                            case 11:
                                {
                                    Console.Clear();
                                    UI1.MakeUI();
                                    PrintMerchant();
                                    PrintShop();
                                    PrintCursorPosition();
                                    UI1.Printstate(albert);
                                    Console.SetCursorPosition(4, 43);
                                    Console.Write("Ak소총을 구매하시겠습니까?");
                                    Console.SetCursorPosition(10, 45);
                                    Console.Write("네");
                                    Console.SetCursorPosition(10, 47);
                                    Console.Write("아니오");
                                    Console.SetCursorPosition(10, 46);
                                    while (true)
                                    {
                                        ConsoleKeyInfo input2 = Console.ReadKey();
                                        switch (input2.Key)
                                        {
                                            case ConsoleKey.UpArrow:
                                                if (Console.CursorTop == 46)
                                                {
                                                    Console.SetCursorPosition(10, 48);
                                                    break;
                                                }
                                                else if (Console.CursorTop == 48)
                                                {
                                                    Console.SetCursorPosition(10, 46);
                                                    break;
                                                }
                                                break;
                                            case ConsoleKey.DownArrow:
                                                if (Console.CursorTop == 46)
                                                {
                                                    Console.SetCursorPosition(10, 48);
                                                    break;
                                                }
                                                else if (Console.CursorTop == 48)
                                                {
                                                    Console.SetCursorPosition(10, 46);
                                                    break;
                                                }
                                                break;
                                            case ConsoleKey.Enter:
                                                if (Console.CursorTop == 46)
                                                {
                                                    if (albert.fossils >= items[0].price)
                                                    {
                                                        Console.SetCursorPosition(4, 43);
                                                        Console.Write("휴먼! 탁월한선택입니다!");
                                                        Console.SetCursorPosition(4, 45);
                                                        Console.Write("아이템구매에 성공했습니다!");
                                                        albert.fossils = items[2].price;
                                                        albert.weaponPower = items[2].power;
                                                        albert.weaponName = items[2].name;
                                                        Task.Delay(1000).Wait();
                                                        Console.SetCursorPosition(33, 7);
                                                        buyCheck = true;
                                                        break;
                                                    }
                                                    else
                                                    {
                                                        Console.Clear();
                                                        UI1.MakeUI();
                                                        PrintMerchant();
                                                        PrintShop();
                                                        PrintCursorPosition();
                                                        UI1.Printstate(albert);
                                                        Console.SetCursorPosition(4, 43);
                                                        Console.Write("그 물건은 당신이 다루기 어려울것입니다.");
                                                        Console.SetCursorPosition(4, 45);
                                                        Console.Write("화석이 부족합니다.");
                                                        Task.Delay(1000).Wait();
                                                        Console.SetCursorPosition(33, 7);
                                                        buyCheck = true;

                                                        
                                                    }
                                                }
                                                else if (Console.CursorTop == 48)
                                                {
                                                    Console.Clear();
                                                    UI1.MakeUI();
                                                    PrintMerchant();
                                                    PrintShop();
                                                    PrintCursorPosition();
                                                    UI1.Printstate(albert);
                                                    Console.SetCursorPosition(4, 43);
                                                    Console.Write("다른물건도 있으니 구경부탁드립니다 휴먼.");
                                                    Task.Delay(1000).Wait();
                                                    Console.SetCursorPosition(33, 7);
                                                    buyCheck = true;
                                                    break;
                                                }
                                                break;
                                        }
                                        if (buyCheck == true)
                                        {
                                            buyCheck = false;
                                            break;
                                        }
                                    }
                                    break;
                                }
                            case 13:
                                {
                                    Console.Clear();
                                    UI1.MakeUI();
                                    PrintMerchant();
                                    PrintShop();
                                    PrintCursorPosition();
                                    UI1.Printstate(albert);
                                    Console.SetCursorPosition(4, 43);
                                    Console.Write("마취연막탄을 구매하시겠습니까?");
                                    Console.SetCursorPosition(10, 45);
                                    Console.Write("네");
                                    Console.SetCursorPosition(10, 47);
                                    Console.Write("아니오");
                                    Console.SetCursorPosition(10, 46);
                                    while (true)
                                    {
                                        ConsoleKeyInfo input2 = Console.ReadKey();
                                        switch (input2.Key)
                                        {
                                            case ConsoleKey.UpArrow:
                                                if (Console.CursorTop == 46)
                                                {
                                                    Console.SetCursorPosition(10, 48);
                                                    break;
                                                }
                                                else if (Console.CursorTop == 48)
                                                {
                                                    Console.SetCursorPosition(10, 46);
                                                    break;
                                                }
                                                break;
                                            case ConsoleKey.DownArrow:
                                                if (Console.CursorTop == 46)
                                                {
                                                    Console.SetCursorPosition(10, 48);
                                                    break;
                                                }
                                                else if (Console.CursorTop == 48)
                                                {
                                                    Console.SetCursorPosition(10, 46);
                                                    break;
                                                }
                                                break;
                                            case ConsoleKey.Enter:
                                                if (Console.CursorTop == 46)
                                                {
                                                    if (albert.fossils >= items[0].price)
                                                    {
                                                        Console.SetCursorPosition(4, 43);
                                                        Console.Write("휴먼! 탁월한선택입니다.!");
                                                        Console.SetCursorPosition(4, 45);
                                                        Console.Write("아이템구매에 성공했습니다!");
                                                        albert.fossils = items[3].price;
                                                        albert.weaponPower = items[3].power;
                                                        albert.weaponName = items[3].name;
                                                        Task.Delay(1000).Wait();
                                                        Console.SetCursorPosition(33, 7);
                                                        buyCheck = true;

                                                        Console.Clear();
                                                        UI1.MakeUI();
                                                        PrintMerchant();
                                                        PrintShop();
                                                        PrintCursorPosition();
                                                        UI1.Printstate(albert);
                                                        break;
                                                    }
                                                    else
                                                    {
                                                        Console.Clear();
                                                        UI1.MakeUI();
                                                        PrintMerchant();
                                                        PrintShop();
                                                        PrintCursorPosition();
                                                        UI1.Printstate(albert);
                                                        Console.SetCursorPosition(4, 43);
                                                        Console.Write("그 물건은 당신이 다루기 어려울것입니다.");
                                                        Console.SetCursorPosition(4, 45);
                                                        Console.Write("화석이 부족합니다.");
                                                        Task.Delay(1000).Wait();
                                                        Console.SetCursorPosition(33, 7);
                                                        buyCheck = true;

                                                       
                                                    }
                                                }
                                                else if (Console.CursorTop == 48)
                                                {
                                                    Console.Clear();
                                                    UI1.MakeUI();
                                                    PrintMerchant();
                                                    PrintShop();
                                                    PrintCursorPosition();
                                                    UI1.Printstate(albert);
                                                    Console.SetCursorPosition(4, 43);
                                                    Console.Write("다른물건도 있으니 구경부탁드립니다 휴먼.");
                                                    Task.Delay(1000).Wait();
                                                    Console.SetCursorPosition(33, 7);
                                                    buyCheck = true;
                                                    break;
                                                }
                                                break;
                                        }
                                        if (buyCheck == true)
                                        {
                                            buyCheck = false;
                                            break;
                                        }
                                    }
                                    break;
                                }
                            case 15:
                                {
                                    Console.Clear();
                                    UI1.MakeUI();
                                    PrintMerchant();
                                    PrintShop();
                                    PrintCursorPosition();
                                    UI1.Printstate(albert);
                                    Console.SetCursorPosition(4, 43);
                                    Console.Write("레이저건을 구매하시겠습니까?");
                                    Console.SetCursorPosition(10, 45);
                                    Console.Write("네");
                                    Console.SetCursorPosition(10, 47);
                                    Console.Write("아니오");
                                    Console.SetCursorPosition(10, 46);
                                    while (true)
                                    {
                                        ConsoleKeyInfo input2 = Console.ReadKey();
                                        switch (input2.Key)
                                        {
                                            case ConsoleKey.UpArrow:
                                                if (Console.CursorTop == 46)
                                                {
                                                    Console.SetCursorPosition(10, 48);
                                                    break;
                                                }
                                                else if (Console.CursorTop == 48)
                                                {
                                                    Console.SetCursorPosition(10, 46);
                                                    break;
                                                }
                                                break;
                                            case ConsoleKey.DownArrow:
                                                if (Console.CursorTop == 46)
                                                {
                                                    Console.SetCursorPosition(10, 48);
                                                    break;
                                                }
                                                else if (Console.CursorTop == 48)
                                                {
                                                    Console.SetCursorPosition(10, 46);
                                                    break;
                                                }
                                                break;
                                            case ConsoleKey.Enter:
                                                if (Console.CursorTop == 46)
                                                {
                                                    if (albert.fossils >= items[0].price)
                                                    {
                                                        Console.SetCursorPosition(4, 43);
                                                        Console.Write("휴먼! 탁월한선택입니다.!");
                                                        Console.SetCursorPosition(4, 45);
                                                        Console.Write("아이템구매에 성공했습니다!");
                                                        albert.fossils = items[0].price;
                                                        albert.weaponPower = items[0].power;
                                                        albert.weaponName = items[0].name;
                                                        Task.Delay(1000).Wait();
                                                        Console.SetCursorPosition(33, 7);
                                                        buyCheck = true;


                                                        break;
                                                    }
                                                    else
                                                    {
                                                        Console.Clear();
                                                        UI1.MakeUI();
                                                        PrintMerchant();
                                                        PrintShop();
                                                        PrintCursorPosition();
                                                        UI1.Printstate(albert);
                                                        Console.SetCursorPosition(4, 43);
                                                        Console.Write("그 물건은 당신이 다루기 어려울것입니다.");
                                                        Console.SetCursorPosition(4, 45);
                                                        Console.Write("화석이 부족합니다.");
                                                        Task.Delay(1000).Wait();
                                                        Console.SetCursorPosition(33, 7);
                                                        buyCheck = true;

                                                       
                                                    }
                                                }
                                                else if (Console.CursorTop == 48)
                                                {
                                                    Console.Clear();
                                                    UI1.MakeUI();
                                                    PrintMerchant();
                                                    PrintShop();
                                                    PrintCursorPosition();
                                                    UI1.Printstate(albert);
                                                    Console.SetCursorPosition(4, 43);
                                                    Console.Write("다른물건도 있으니 구경부탁드립니다 휴먼.");
                                                    Task.Delay(1000).Wait();
                                                    Console.SetCursorPosition(33, 7);
                                                    buyCheck = true;
                                                    break;
                                                }
                                                break;
                                        }
                                        if (buyCheck == true)
                                        {
                                            buyCheck = false;
                                            break;
                                        }
                                    }
                                    break;
                                }
                        }break;
                    case ConsoleKey.Escape:   // esc를 눌러 상점을 떠나려는 경우
                        {
                            Console.Clear();
                            UI1.MakeUI();
                            PrintMerchant();
                            PrintShop();
                            PrintCursorPosition();
                            UI1.Printstate(albert);
                            Console.SetCursorPosition(4, 43);
                            Console.Write("정말 상점을 떠나시겠습니까?");
                            Console.SetCursorPosition(4, 45);
                            Console.Write("네");
                            Console.SetCursorPosition(10, 45);
                            Console.Write("아니오");
                          
                            closeShop = true;
                            break;

                        }
                        break;
                }
                if(closeShop == true)
                {
                    Console.SetCursorPosition(4, 43);
                    Console.Write("떠나기전에 조그만선물을 드리겠습니다.");
                    Console.SetCursorPosition(4, 45);
                    Console.Write("많은 이용 부탁드리겠습니다. 삐빅!");
                    Console.SetCursorPosition(4, 47);
                    Console.Write("공룡알 하나를 얻었다!!!");
                    Task.Delay(1000).Wait();
                    break;
                }
            }
        }
    }
}
