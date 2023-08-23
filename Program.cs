using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Xml.Serialization;

namespace TRPG_개인과제
{
    
    internal class Program
    {
        private static Character player;
        private static Item item1, item2, item3,item4,item5,item6;
        



        static void Main(string[] args)
        {
            DisplayGameStart();
        }
        static void DisplayGameStart() //첫화면 
        {
            Console.Clear();

            Console.WriteLine("=== \r\n  _____ ____   ____  ____  ______   ____      __ __  ____  _      _       ____   ____    ___      ____   ____   ____ \r\n / ___/|    \\ /    ||    \\|      | /    |    |  |  ||    || |    | |     /    | /    |  /  _]    |    \\ |    \\ /    |\r\n(   \\_ |  o  )  o  ||  D  )      ||  o  |    |  |  | |  | | |    | |    |  o  ||   __| /  [_     |  D  )|  o  )   __|\r\n \\__  ||   _/|     ||    /|_|  |_||     |    |  |  | |  | | |___ | |___ |     ||  |  ||    _]    |    / |   _/|  |  |\r\n /  \\ ||  |  |  _  ||    \\  |  |  |  _  |    |  :  | |  | |     ||     ||  _  ||  |_ ||   [_     |    \\ |  |  |  |_ |\r\n \\    ||  |  |  |  ||  .  \\ |  |  |  |  |     \\   /  |  | |     ||     ||  |  ||     ||     |    |  .  \\|  |  |     |\r\n  \\___||__|  |__|__||__|\\_| |__|  |__|__|      \\_/  |____||_____||_____||__|__||___,_||_____|    |__|\\_||__|  |___,_|\r\n                                                                                                                     \r\n ===");
            Console.WriteLine();
            Console.WriteLine("1. 게임 시작");
            Console.WriteLine("2. 종료");
            Console.WriteLine();
            Console.WriteLine("원하시는 행동을 선택해주세요.");

            int input = CheckValidInput(1, 2);
            switch (input)
            {
                case 1:
                    StartGame();
                    break;
                case 2:
                    Environment.Exit(0); //게임 종료
                    break;
            }
        }
        static void StartGame()
        {
            GameDataSetting();
            DisplayGameIntro();
        }

        static void GameDataSetting() //캐릭터,아이템 정보 세팅
        {
            // 캐릭터 정보 세팅
            player = new Character("JB", "전사", 1, 10, 5, 100, 200, 1500); //(이름,직업,lv, 공력,방어력,hp,mp,골드)

            // 아이템 정보 세팅
            item1 = new Item("무쇠갑옷",1, 0, 9, "무쇠로 만들어져 튼튼한 갑옷입니다.", 2000);//2000g
            item2 = new Item("낡은 검",2, 2, 0, "쉽게 볼 수 있는 낡은 검입니다.", 500); // 500g
            item3 = new Item("예리한 창",3, 6, 0, "잘 만들어진 창입니다.", 1800); //1800g
            item4 = new Item("수련자 갑옷",4, 0, 5, "수련에 도움을 주는 갑옷입니다", 1000); //1000g
            item5 = new Item("스파르타의 갑옷",5, 0, 15, "스파르타의 전사들이 사용했다는 전설의 갑옷입니다.", 3500); //3500g
            item6 = new Item("청동 도끼",6, 5, 0, "어디선가 사용됐던거 같은 도끼입니다.", 1500); //1500g


        }

        static void DisplayGameIntro() //메인 화면
        {
            Console.Clear();

            Console.ForegroundColor = ConsoleColor.Cyan; //컬러cyan
            Console.WriteLine("메인");
            Console.ResetColor(); //컬러 리셋
            Console.WriteLine();

            Console.WriteLine("스파르타 마을에 오신 여러분 환영합니다.");
            Console.WriteLine("이곳에서 던전으로 들어가기 전 활동을 할 수 있습니다.");
            Console.WriteLine();
            Console.WriteLine("1. 상태보기");
            Console.WriteLine("2. 인벤토리");
            Console.WriteLine("3. 상점");
            Console.WriteLine("4. 10000 G 얻기");
            Console.WriteLine("5. 던전");
            Console.WriteLine();
            Console.WriteLine("0. 처음화면 (리셋)");
            Console.WriteLine();

            Console.WriteLine("원하시는 행동을 입력해주세요.");

            int input = CheckValidInput(0, 5);
            switch (input)
            {
                case 0:
                    DisplayGameStart(); 
                    break;

                case 1:
                    DisplayMyInfo();
                    break;

                case 2:
                    // 작업해보기
                    Inventory();
                    break;
                case 3:
                    //상점
                    Shop();
                    break;
                case 4:
                    //골드 얻기(임시)
                    GainGold();
                    break;
                case 5:
                    DungeonEntry();
                    break;
            }
        }
        static void DungeonEntry() //던전 
        {
            Console.Clear();

            Console.ForegroundColor = ConsoleColor.DarkGray; //컬러 그린
            Console.WriteLine("던전입구");
            Console.ResetColor(); //컬러 리셋
            Console.WriteLine("이곳에서 던전으로 들어가기전 활동을 할 수 있습니다.");
            Console.WriteLine();




        }

        static void GainGold() //임시로 상점기능을 확인하기위해 1000골드를 얻는 코드
        {           
            player.Gold += 10000;
                        
            Console.ForegroundColor = ConsoleColor.Magenta; //컬러 마젠타
            Console.WriteLine("10000골드를 얻었습니다!");
            Console.ResetColor(); //컬러 리셋

            Console.WriteLine("아무 키나 누르시면 상태창을 띄웁니다.");
            Console.ReadKey(intercept: true);
            DisplayMyInfo();

        }

        static void DisplayMyInfo()
        {

            Console.Clear();

            Console.ForegroundColor = ConsoleColor.Green; //컬러 그린
            Console.WriteLine("상태보기");
            Console.ResetColor(); //컬러 리셋
            
            Console.WriteLine("캐릭터의 정보를 표시합니다.");
            Console.WriteLine();
            Console.WriteLine("----------------------------------------------------");
            Console.WriteLine($"Lv.{player.Level}                 ");
            Console.WriteLine($"{player.Name} ({player.Job})            ");
            Console.WriteLine("                     ");
            Console.WriteLine($"공격력 : {player.Atk} (+{(player.EquippedWeapon != null && player.EquippedArmor.IsPurchased ? player.EquippedWeapon.AttackPower : 0)})");
            Console.WriteLine($"방어력 : {player.Def} (+{(player.EquippedArmor != null && player.EquippedArmor.IsPurchased ? player.EquippedArmor.Armor : 0)})");      
            Console.WriteLine($"체력 : {player.Hp}           ");
            Console.WriteLine($"Gold : {player.Gold} G        ");
            Console.WriteLine("----------------------------------------------------"); 
            Console.WriteLine();

            
            Console.WriteLine("아무 키나 누르면 메인화면으로 돌아갑니다.");
            Console.ReadKey(intercept: true);
            DisplayGameIntro();
        }
        static void Shop()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Yellow; //컬러 노랑
            Console.WriteLine("상점");
            Console.ResetColor(); //컬러 리셋

            Console.WriteLine("필요한 아이템을 얻을 수 있는 상점입니다.");
            Console.WriteLine();
            Console.WriteLine("[보유 골드]");
            Console.WriteLine($"{player.Gold} G");
            Console.WriteLine();

            Console.WriteLine("[아이템 목록]");
            Console.WriteLine("- 아이템 이름".PadRight(20) + "| 능력치".PadRight(10) + "| 가격".PadRight(15) + "| 상태");
            Console.WriteLine(new string('-', 70));

            DisplayItemInfo(item1);
            DisplayItemInfo(item2);
            DisplayItemInfo(item3);
            DisplayItemInfo(item4);
            DisplayItemInfo(item5);
            DisplayItemInfo(item6);

            //수동으로 열을 맞춤
            //Console.WriteLine($"- 1. {item1.ItemName}         | 방어력 {item1.Armor}  | {item1.Description}                  | {item1.ItemGold} G | {(item1.IsPurchased ? "구매완료[v]" : "")}");
            //Console.WriteLine($"- 2. {item2.ItemName}          | 공격력 {item2.AttackPower}  | {item2.Description}                      | {item2.ItemGold}  G | {(item2.IsPurchased ? "구매완료[v]" : "")}");
            //Console.WriteLine($"- 3. {item3.ItemName}        | 공격력 {item3.AttackPower}  | {item2.Description}                      | {item3.ItemGold} G | {(item3.IsPurchased ? "구매완료[v]" : "")}");
            //Console.WriteLine($"- 4. {item4.ItemName}      | 방어력 {item4.Armor}  | {item4.Description}                       | {item4.ItemGold} G | {(item4.IsPurchased ? "구매완료[v]" : "")}");
            //Console.WriteLine($"- 5. {item5.ItemName}  | 방어력 {item5.Armor} | {item5.Description}   | {item5.ItemGold} G | {(item5.IsPurchased ? "구매완료[v]" : "")}");
            //Console.WriteLine($"- 6. {item6.ItemName}        | 공격력 {item6.AttackPower}  | {item6.Description}                | {item6.ItemGold} G | {(item6.IsPurchased ? "구매완료[v]" : "")}");
            Console.WriteLine();

            Console.WriteLine("2. 판매하기");
            Console.WriteLine("1. 구매하기");
            Console.WriteLine("0. 나가기");


            int input = CheckValidInput(0, 2);
            switch (input)
            {
                case 0:
                    DisplayGameIntro();
                    break;
                case 1:
                    BuyItem();
                    Shop();
                    break;
                case 2:
                    SellItem();
                    Shop();
                    break;
            }

        }
        static void DisplayItemInfo(Item item)
        {
            string purchaseStatus = item.IsPurchased ? "구매완료[v]" : "구매가능";
            
            string itemStats = GetItemInfo(item);
            string itemLine = $"- {item.ItemNumber}. {item.ItemName}".PadRight(20) +
                              $"| {itemStats}".PadRight(10) +
                              $"| {item.ItemGold} G".PadRight(5) +
                              $"| {purchaseStatus}".PadLeft(15);

            Console.WriteLine(itemLine);
        }


        static void BuyItem()
        {
            Console.Clear();

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("상점 - 구매하기");
            Console.ResetColor();

            Console.WriteLine("구매할 아이템의 번호를 입력해주세요.");
            Console.WriteLine();

            Console.WriteLine($"- 1. {item1.ItemName}         | 방어력 {item1.Armor}  | {item1.Description}                  | {item1.ItemGold} G | {(item1.IsPurchased ? "구매완료[v]" : "구매하기")}");
            Console.WriteLine($"- 2. {item2.ItemName}          | 공격력 {item2.AttackPower}  | {item2.Description}                      | {item2.ItemGold}  G | {(item2.IsPurchased ? "구매완료[v]" : "구매하기")}");
            Console.WriteLine($"- 3. {item3.ItemName}        | 공격력 {item3.AttackPower}  | {item2.Description}                      | {item3.ItemGold} G | {(item3.IsPurchased ? "구매완료[v]" : "구매하기")}");
            Console.WriteLine($"- 4. {item4.ItemName}      | 방어력 {item4.Armor}  | {item4.Description}                       | {item4.ItemGold} G | {(item4.IsPurchased ? "구매완료[v]" : "구매하기")}");
            Console.WriteLine($"- 5. {item5.ItemName}  | 방어력 {item5.Armor} | {item5.Description}   | {item5.ItemGold} G | {(item5.IsPurchased ? "구매완료[v]" : "구매하기")}");
            Console.WriteLine($"- 6. {item6.ItemName}        | 공격력 {item6.AttackPower}  | {item6.Description}                | {item6.ItemGold} G | {(item6.IsPurchased ? "구매완료[v]" : "구매하기")}");
            Console.WriteLine();
            //Console.WriteLine("1. 수련자 갑옷  | 방어력 +5  | 1000 G");
            //Console.WriteLine("2. 스파르타의 갑옷 | 방어력 +15 | 3500 G");
            //Console.WriteLine("3. 청동 도끼 | 공격력 +5 | 1500 G");
            Console.WriteLine();
            Console.WriteLine("0. 뒤로 가기");

            int input = CheckValidInput(0, 6);
            switch (input)
            {
                case 0:
                    Shop();
                    break;
                case 1:
                    BuyItem(item1, 2000);
                    break;
                case 2:
                    BuyItem(item2, 500);
                    break;
                case 3:
                    BuyItem(item3, 1800);
                    break;
                case 4:
                    BuyItem(item4, 1000);
                    break;
                case 5:
                    BuyItem(item5, 3500);
                    break;
                case 6:
                    BuyItem(item6, 1500);
                    break;
            }
        }

        static void BuyItem(Item item, int price) // overloading 
        {
            if (player.Gold >= price)
            {
                player.Gold -= price;

                if (item.Armor > 0)
                {
                    player.EquipArmor(item);
                }
                else if (item.AttackPower > 0)
                {
                    player.EquipWeapon(item);
                }

                item.MarkAsPurchased(); // 구매한 아이템 표시

                Console.WriteLine($"{item.ItemName}을(를) 구매하였습니다.");

                player.AddToCharacter(item); // 구매 아이템 캐릭터에 추가장착
            }
            else if (item.IsPurchased)
            {
                Console.WriteLine("이미 구매한 아이템입니다.");
            }
            else
            {
                Console.WriteLine("골드가 부족합니다.");

            }

            Console.WriteLine("아무 키나 누르면 돌아갑니다.");
            Console.ReadKey(intercept: true);

            Shop();
        }
        static void Inventory() //인벤토리
        {
            Console.Clear();

            Console.ForegroundColor = ConsoleColor.Red; //컬러 레드
            Console.WriteLine("인벤토리");
            Console.ResetColor(); //컬러 리셋

            Console.WriteLine("보유 중인 아이템을 관리할 수 있습니다.");
            Console.WriteLine();
            Console.WriteLine("[아이템 목록]");
            // 아이템 목록 출력
            foreach (var item in player.Inventory)
            {
                string itemName = $"{item.ItemName}";
                Console.WriteLine($"- {item.ItemName} | {GetItemInfo(item)} | {item.Description}");
            }

            //이 코드를 위의 코드로 대체
            //if (player.IsArmorEquipped(item1))
            //{
            //    Console.WriteLine($"- [E]{item1.ItemName}     | 방어력 {item1.Armor} | {item1.Description}");
            //}
            //else
            //{
            //    Console.WriteLine($"- {item1.ItemName}         | 방어력 {item1.Armor} | {item1.Description}");
            //}
            //if (player.IsWeaponEquipped(item2))
            //{
            //    Console.WriteLine($"- [E]{item2.ItemName}          | 공격력 {item2.AttackPower} | {item2.Description}");
            //}
            //else
            //{
            //    Console.WriteLine($"- {item2.ItemName}          | 공격력 {item2.AttackPower} | {item2.Description}");
            //}
            //if (player.IsWeaponEquipped(item3))
            //{
            //    Console.WriteLine($"- [E]{item3.ItemName}        | 공격력 {item3.AttackPower} | {item3.Description}");
            //}
            //else
            //{
            //    Console.WriteLine($"- {item3.ItemName}        | 공격력 {item3.AttackPower} | {item3.Description}");
            //}

            Console.WriteLine();

            Console.WriteLine("2. 아이템 정렬");
            Console.WriteLine("1. 장착 관리");
            Console.WriteLine("0. 나가기");

            int input = CheckValidInput(0, 2);
            switch (input)
            {
                case 0:
                    DisplayGameIntro();
                    break;
                case 1:
                    InventoryManager();
                    break;
                case 2:
                    InventoryInorderName(); 
                    break;
            }

            Console.WriteLine();

            Console.WriteLine("원하시는 행동을 입력해주세요.");

            //static string GetItemInfo(Item item)
            //{
            //    if (item.Armor > 0)
            //    {
            //        return $"방어력 {item.Armor} | {item.Description}";
            //    }
            //    else if (item.AttackPower > 0)
            //    {
            //        return $"공격력 {item.AttackPower} | {item.Description}";

            //    }
            //    return "";
            //}
        }

        static void SellItem()
        {
            Console.Clear();

            Console.ForegroundColor= ConsoleColor.Yellow;
            Console.WriteLine("상점 - 판매하기");
            Console.ResetColor();

            Console.WriteLine();

            Console.WriteLine("판매할 아이템의 번호를 입력해주세요.");
            Console.WriteLine();

            for (int i = 0; i < player.Inventory.Count; i++)
            {
                var item = player.Inventory[i];
                string equippedMark = "";

                if (player.IsArmorEquipped(item) || player.IsWeaponEquipped(item))
                {
                    equippedMark = "[E}";
                }

                Console.WriteLine($" - {equippedMark} {i + 1}. {item.ItemName} | {GetItemInfo(item)} | 판매가격: {item.ItemGold / 2} G"); 
            }

            Console.WriteLine();
            Console.WriteLine("0. 상점으로");

            int input = CheckValidInput(0, player.Inventory.Count);
            if (input == 0)
            {
                Shop();
            }
            else
            {
                SellSelectedItem(player.Inventory[input - 1]);
            }
        }

        static void SellSelectedItem(Item item)
        {
            Console.Clear();

            Console.WriteLine($"{item.ItemName}을(를) 판매하시겠습니까? (Y/N)");

            ConsoleKeyInfo key = Console.ReadKey(intercept: true);

            if (key.Key == ConsoleKey.Y)
            {
                int sellPrice = item.ItemGold / 2;
                player.Gold += sellPrice;
                player.RemoveFromInventory(item);

                Console.WriteLine($"{item.ItemName}을(를) 판매했습니다. {sellPrice} G를 획득했습니다.");

                //아이템 정보 초기화
                //item.AttackPower = 0;
                //item.Armor = 0;
                item.IsPurchased = false;


                Console.WriteLine("아무 키나 누르면 돌아갑니다.");
                Console.ReadKey(intercept: true);

                Shop();
            }
            else
            {
                Console.WriteLine("판매를 취소하였습니다.");

                Console.WriteLine("아무 키나 누르면 돌아갑니다.");
                Console.ReadKey(intercept: true);

                SellItem();
            }
        }

        static void InventoryInorderName() //아이템을 인벤토리에 이름순으로 정렬
        {
            Console.Clear();

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("인벤토리 - 아이템 정렬(이름순)");
            Console.ResetColor();

            Console.WriteLine("보유 중인 아이템을 이름순으로 정렬 할 수 있습니다.");
            Console.WriteLine();
            Console.WriteLine("[아이템 목록]");

            var sortedInventory = player.Inventory.OrderBy(item => item.ItemName);

            foreach (var item in sortedInventory)
            {
                string equippedMark = "";

                if (player.IsArmorEquipped(item) || player.IsWeaponEquipped(item))
                {
                    equippedMark = "[E]";
                }

                Console.WriteLine($"- {equippedMark} {item.ItemName}  | {GetItemInfo(item)} | {item.Description}");
            }
            Console.WriteLine();
            Console.WriteLine("0. 나가기");

            int input = CheckValidInput(0, sortedInventory.Count());
            if (input == 0)
            {
                Inventory();
            }
            else
            {
                EquipOrUnequip(sortedInventory.ElementAt(input -1));
            }
            
    }


        static void InventoryManager() //아이템 장착 관리
        {
            Console.Clear();

            Console.ForegroundColor = ConsoleColor.Red; //컬러 레드
            Console.WriteLine("인벤토리 - 장착 관리");
            Console.ResetColor(); //컬러 리셋

            Console.WriteLine("보유 중인 아이템을 관리할 수 있습니다.");
            Console.WriteLine();
            Console.WriteLine("[아이템 목록]");

            //static string GetItemInfo(Item item) //아이템의 정보 가져오기
            //{
            //    if (item.Armor > 0)
            //    {
            //        return $"방어력 {item.Armor} | {item.Description}";
            //    }
            //    else if (item.AttackPower > 0)
            //    {
            //        return $"공격력 {item.AttackPower} | {item.Description}";

            //    }
            //    return "";
            //}

            //장착관리 창 목록
            for (int i = 0; i < player.Inventory.Count; i++)
            {
                var item = player.Inventory[i];
                string equippedMark = "";

                if (player.IsArmorEquipped(item) || player.IsWeaponEquipped(item))
                {
                    equippedMark = "[E]";
                }

                Console.WriteLine($"- {equippedMark} {i + 1}. {item.ItemName}   | {GetItemInfo (item)} | {item.Description}");
            }

            //아이템 3개 장착관리 목록 (수정 전 버전)
            //Console.WriteLine($"- 1. {item1.ItemName}         | 방어력 {item1.Armor} | {item1.Description}");
            //Console.WriteLine($"- 2. {item2.ItemName}          | 공격력 {item2.AttackPower} | {item2.Description}");
            //Console.WriteLine($"- 3. {item3.ItemName}        | 공격력 {item3.AttackPower} | {item3.Description}");

            Console.WriteLine();
            Console.WriteLine("장착을 원하시는 장비의 번호를 눌러주세요.");
            Console.WriteLine();
            Console.WriteLine("0. 나가기");

            int input = CheckValidInput(0, player.Inventory.Count);
            if (input == 0)
            {
                Inventory();
            }
            else
            {
                EquipOrUnequip(player.Inventory[input - 1]); //인덱스는 0부터 시작 그러므로 '-1'
            }

            //Validate한지 체크하는 switch문 (수정전버전)
            //int input = CheckValidInput(0, 3);
            //switch (input)
            //{
            //    case 0:
            //        DisplayGameIntro();
            //        break;
            //    case 1:
            //        EquipOrUnequip(item1);
            //        break;
            //    case 2:
            //        EquipOrUnequip(item2);
            //        break;
            //    case 3:
            //        EquipOrUnequip(item3);
            //        break;
            //}

            //Console.WriteLine();

            //Console.WriteLine("원하시는 행동을 입력해주세요.");
        }
        static void EquipOrUnequip(Item item) //장착,해제
        {
            Console.Clear();
            Console.WriteLine($"E 를 누르면 {item.ItemName}을(를) 장착합니다.");
            Console.WriteLine("U 를 누르면 장착한 아이템을 해제합니다.");
            Console.WriteLine("나머지 키를 누르면 돌아갑니다.");

            ConsoleKeyInfo key = Console.ReadKey(intercept: true);

            switch (key.Key)
            {
                case ConsoleKey.E:
                    if (item == item1)
                    {
                        player.EquipArmor(item1);
                    }
                    else
                    {
                        player.EquipWeapon(item);
                    }
                    break;
                case ConsoleKey.U:
                    if (item == item1)
                    {
                        player.UnequipArmor();
                    }
                    else
                    {
                        player.UnequipWeapon();
                    }
                    break;
            }
            Console.WriteLine("아무 키나 누르면 돌아갑니다.");
            Console.ReadKey(intercept: true);

            DisplayGameIntro(); //게임 메인 화면으로
        }
        static int CheckValidInput(int min, int max) //입력된 숫자가 valid한지를 체크
        {
            while (true)
            {
                string input = Console.ReadLine();

                bool parseSuccess = int.TryParse(input, out var ret);
                if (parseSuccess)
                {
                    if (ret >= min && ret <= max)
                        return ret;
                }

                Console.WriteLine("잘못된 입력입니다.");
            }
        }
        static string GetItemInfo(Item item) //아이템의 정보를 가지고있음 (방어력.공격력)
        {
            if (item.Armor > 0)
            {
                return $"방어력 {item.Armor}";
            }
            else if (item.AttackPower > 0)
            {
                return $"공격력 {item.AttackPower}";

            }
            return "";
        }

    }
}
    