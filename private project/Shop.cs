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
            Console.Write("풀숲을 거니던 도중 부유해보이는 상인을 발견했습니다.");
            Console.SetCursorPosition(4, 45);
            Console.Write("그는 잃어버렸던 무기를 포함해 다양한것들을 가지고있었습니다.");
            Console.SetCursorPosition(4, 47);
            Console.Write("안녕하신가? 나는 시공간 상인 코브라고하네. 내 물건을 구경해보겠는가?");

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

        public void Buy(UI UI1,Player albert)
        {
            bool buyCheck1 = false;
            bool buyCheck2 = false;
            bool buyCheck3 = false;
            bool closeShop = false;
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
                            case 5:
                                {
                                    Console.Clear();
                                    UI1.MakeUI();
                                    PrintShop();
                                    PrintCursorPosition();
                                    UI1.Printstate(albert);
                                    Console.SetCursorPosition(4, 43);
                                    Console.Write("돌창을 구매하시겠습니까?");
                                    Console.SetCursorPosition(10, 45);
                                    Console.Write("네");
                                    Console.SetCursorPosition(14, 45);
                                    Console.Write("아니오");
                                    Console.SetCursorPosition(10, 46);
                                    /*ConsoleKeyInfo input2 = Console.ReadKey();
                                    switch (input2.Key)
                                    {
                                        case ConsoleKey.Y:
                                            Console.SetCursorPosition(4, 43);
                                            Console.Write("껄껄껄! 아주 좋은선택 한걸세~~");
                                            Task.Delay(1000).Wait();
                                            Console.SetCursorPosition(30, 5);
                                            buyCheck2 = true;
                                            break;
                                        case ConsoleKey.N:
                                            Console.SetCursorPosition(4, 43);
                                            Console.Write("흐으음... 다른것을 구경해보는것은 어떤가?");
                                            Task.Delay(1000).Wait();
                                            Console.SetCursorPosition(30, 5);
                                            buyCheck2 = true;
                                            break;
                                    }*/
                                }
                                if (buyCheck2 == true)
                                {
                                    buyCheck2 = false;
                                    break;
                                }
                                break;
                            case 7:
                                {
                                    Console.Clear();
                                    UI1.MakeUI();
                                    PrintShop();
                                    PrintCursorPosition();
                                    UI1.Printstate(albert);
                                    Console.SetCursorPosition(4, 43);
                                    Console.Write("청동검을 구매하시겠습니까?");
                                    Console.SetCursorPosition(10, 45);
                                    Console.Write("네");
                                    Console.SetCursorPosition(14, 45);
                                    Console.Write("아니오");
                                    Console.SetCursorPosition(10, 46);
                                    if (buyCheck2 == true)
                                    {
                                        buyCheck2 = false;
                                        break;
                                    }
                                    break;
                                }
                            case 9:
                                {
                                    Console.Clear();
                                    UI1.MakeUI();
                                    PrintShop();
                                    PrintCursorPosition();
                                    UI1.Printstate(albert);
                                    Console.SetCursorPosition(4, 43);
                                    Console.Write("Ak소총을 구매하시겠습니까?");
                                    Console.SetCursorPosition(10, 45);
                                    Console.Write("네");
                                    Console.SetCursorPosition(14, 45);
                                    Console.Write("아니오");
                                    Console.SetCursorPosition(10, 46);
                                    if (buyCheck2 == true)
                                    {
                                        buyCheck2 = false;
                                        break;
                                    }
                                }
                                break;
                            case 11:
                                {
                                    Console.Clear();
                                    UI1.MakeUI();
                                    PrintShop();
                                    PrintCursorPosition();
                                    UI1.Printstate(albert);
                                    Console.SetCursorPosition(4, 43);
                                    Console.Write("마취연막탄을 구매하시겠습니까?");
                                    Console.SetCursorPosition(10, 45);
                                    Console.Write("네");
                                    Console.SetCursorPosition(14, 45);
                                    Console.Write("아니오");
                                    Console.SetCursorPosition(10, 46);
                                    if (buyCheck2 == true)
                                    {
                                        buyCheck2 = false;
                                        break;
                                    }
                                    break;
                                }
                            case 13:
                                {
                                    Console.Clear();
                                    UI1.MakeUI();
                                    PrintShop();
                                    PrintCursorPosition();
                                    UI1.Printstate(albert);
                                    Console.SetCursorPosition(4, 43);
                                    Console.Write("레이저건을 구매하시겠습니까?");
                                    Console.SetCursorPosition(10, 45);
                                    Console.Write("네");
                                    Console.SetCursorPosition(14, 45);
                                    Console.Write("아니오");
                                    Console.SetCursorPosition(10, 46);
                                    if (buyCheck2 == true)
                                    {
                                        buyCheck2 = false;
                                        break;
                                    }
                                    break;
                                }
                        }break;
                    case ConsoleKey.Escape:   // esc를 눌러 상점을 떠나려는 경우
                        {
                            Console.Clear();
                            UI1.MakeUI();
                            PrintShop();
                            PrintCursorPosition();
                            UI1.Printstate(albert);
                            Console.SetCursorPosition(4, 43);
                            Console.Write("정말 상점을 떠나겠나?");
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
                    Console.Write("떠나기전에 조그만선물을 주겠네");
                    Console.SetCursorPosition(4, 45);
                    Console.Write("다음에 또보자구 친구!");
                    Console.SetCursorPosition(4, 47);
                    Console.Write("공룡알 하나를 얻었다!!!");
                    Task.Delay(1000).Wait();
                    break;
                }
            }
        }
    }
}
