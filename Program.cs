

namespace linq
{
    class Program
    {
        static void Main(string[] args)
        {
            Aggregate();
            // Find the words in the collection that start with the letter 'L'
            List<string> fruits = new List<string>() { "Lemon", "Apple", "Orange", "Lime", "Watermelon", "Loganberry" };

            IEnumerable<string> LFruits = from fruit in fruits
                                          where fruit.StartsWith("L")
                                          select fruit;


            foreach (string fruit in LFruits)
            {
                Console.WriteLine(fruit);
            }

            // Which of the following numbers are multiples of 4 or 6
            List<int> numbers = new List<int>()
            {
             15, 8, 21, 24, 32, 13, 30, 12, 7, 54, 48, 4, 49, 96
            };

            IEnumerable<int> fourSixMultiples = numbers.Where(n => n % 4 == 0 || n % 4 == 0).OrderBy(n => n);

            foreach (int number in fourSixMultiples)
            {
                Console.WriteLine(number);
            }

            // Order these student names alphabetically, in descending order (Z to A)
            List<string> names = new List<string>()
{
            "Heather", "James", "Xavier", "Michelle", "Brian", "Nina",
            "Kathleen", "Sophia", "Amir", "Douglas", "Zarley", "Beatrice",
            "Theodora", "William", "Svetlana", "Charisse", "Yolanda",
            "Gregorio", "Jean-Paul", "Evangelina", "Viktor", "Jacqueline",
            "Francisco", "Tre"
        };

            List<string> descend = names.OrderByDescending(n => n).ToList();

            descend.ForEach(name => Console.WriteLine($"{name}"));



            // Build a collection of these numbers sorted in ascending order
            List<int> Numbers = new List<int>()
            {
                15, 8, 21, 24, 32, 13, 30, 12, 7, 54, 48, 4, 49, 96
            };
            List<int> ascend = Numbers.OrderBy(n => n).ToList();

            ascend.ForEach(numbers => Console.WriteLine($"{numbers}"));

        static void Aggregate()
        {
            // Output how many numbers are in this list
            List<int> Numbers = new List<int>()
        {
            15, 8, 21, 24, 32, 13, 30, 12, 7, 54, 48, 4, 49, 96
        };


            int listTotal = Numbers.Count;
            Console.WriteLine(listTotal);


            // How much money have we made?
            List<double> purchases = new List<double>()
        {
            2340.29, 745.31, 21.76, 34.03, 4786.45, 879.45, 9442.85, 2454.63, 45.65
        };

            double total = purchases.Sum();

            Console.WriteLine($"{total.ToString("C")}");



            // What is our most expensive product?
            List<double> prices = new List<double>()
        {
            879.45, 9442.85, 2454.63, 45.65, 2340.29, 34.03, 4786.45, 745.31, 21.76
        };
            double highestCost = prices.Max();
            Console.WriteLine($"{highestCost.ToString("C")}");
        }




            List<int> wheresSquaredo = new List<int>()
        {
            66, 12, 8, 27, 82, 34, 7, 50, 19, 46, 81, 23, 30, 4, 68, 14
        };
            /*
                Store each number in the following List until a perfect square
                is detected.

                Expected output is { 66, 12, 8, 27, 82, 34, 7, 50, 19, 46 } 

                Ref: https://msdn.microsoft.com/en-us/library/system.math.sqrt(v=vs.110).aspx
            */
            IEnumerable<int> PerfectSquare = wheresSquaredo.TakeWhile(n => (Math.Sqrt(n) % 1) != 0);

            foreach (int n in wheresSquaredo)
            {
                Console.WriteLine(n);
            }


            
             List<Customer> customers = new List<Customer>()
            {
                new Customer() { Name = "Bob Lesman", Balance = 80345.66, Bank = "FTB" },
                new Customer() { Name = "Joe Landy", Balance = 9284756.21, Bank = "WF" },
                new Customer() { Name = "Meg Ford", Balance = 487233.01, Bank = "BOA" },
                new Customer() { Name = "Peg Vale", Balance = 7001449.92, Bank = "BOA" },
                new Customer() { Name = "Mike Johnson", Balance = 790872.12, Bank = "WF" },
                new Customer() { Name = "Les Paul", Balance = 8374892.54, Bank = "WF" },
                new Customer() { Name = "Sid Crosby", Balance = 957436.39, Bank = "FTB" },
                new Customer() { Name = "Sarah Ng", Balance = 56562389.85, Bank = "FTB" },
                new Customer() { Name = "Tina Fey", Balance = 1000000.00, Bank = "CITI" },
                new Customer() { Name = "Sid Brown", Balance = 49582.68, Bank = "CITI" }
            };
            var millionareList = customers.Where(m => m.Balance >= 1000000);

               List<BankReport> bankNameReport = (from 
            customer in millionareList
            group customer by customer.Bank into BankReport
            select new BankReport 
                {
                    BankName = BankReport.Key,
                    BankCount = BankReport.Count()
                }
            ).ToList();    

              foreach (BankReport info in bankNameReport)
            {
                Console.WriteLine($"{info.BankName} {info.BankCount}") ;
            }

        
            /*
                Given the same customer set, display how many millionaires per bank.
                Ref: https://stackoverflow.com/questions/7325278/group-by-in-linq
                Example Output:
                WF 2
                BOA 1
                FTB 1
                CITI 1
            */
            }
        
        }

    }
