using System;
using System.Collections.Generic;
using System.Linq;

namespace LINQOperations
{
    class Program
    {
        class Person
        {
            public string Name;
            public int Age;
        }


       



        static void Main(string[] args)
        {

            //var numbers = Enumerable.Range(1, 3);
            //var squares = numbers.Select(x => x * x);


            string sentence = "This is a nice sentence";
            //var wordLengths = sentence.Split().Select(w => w.Length);
            var wordLengths = sentence.Split().Select(w => new {Word = w, Size = w.Length });
            //Console.WriteLine(wordLengths);


            var sequences = new[] { "red,green,blue", "orange", "white,pink" };
            //var flaten = sequences.Select(s => s.Split(",")); it din't flatten it returned only string []
            var flaten = sequences.SelectMany(s => s.Split(","));


           
            //foreach (var n in flaten)
            //{
            //    Console.WriteLine(n);
            //}

            // select each pair (cross product) from two collections
            string[] objects = { "house", "car", "bicycle" };
            string[] colors = { "red", "green", "gray" };
            var pairs = colors.SelectMany(z => objects, (c, o) => $"{c} {o}");
            //Console.WriteLine(pairs);


            var numbers = Enumerable.Range(1, 10);
            var evennumbers = numbers.Select(x => x * x).Where(y => y % 2 == 0 );

            //foreach (var n in evennumbers)
            //{
            //    if (Convert.ToInt32(n) < 50)
            //    {
            //        Console.WriteLine(n);
            //    }
            //}


            //var rand = new Random();
            //var randomValues = Enumerable.Range(1, 10).Select(_ => rand.Next(10) - 5);

            //var csvString = new Func<IEnumerable<int>, string>(values =>
            //{
            //    return string.Join(",", values.Select(v => v.ToString()).ToArray());
            //});

            //// different set of values each time
            //Console.WriteLine(csvString(randomValues));
            //Console.WriteLine(csvString(randomValues.OrderBy(x => x)));
            //Console.WriteLine(csvString(randomValues.OrderByDescending(x => x)));

            var people = new List<Person>
            {
              new Person { Name = "Adam", Age = 36 },
              new Person { Name = "Boris", Age = 18 },
              new Person { Name = "Claire", Age = 36 },
              new Person { Name = "Adam", Age = 20 },
              new Person { Name = "Jack", Age = 20 }
            };

            //Console.WriteLine(people);
            //Console.WriteLine(people.OrderBy(p => p.Name));

            ////result is IOrderedEnumerable<Person>

            //Console.WriteLine(people.OrderBy(p => p.Age)
            //                        .ThenByDescending(p => p.Name));


            var GroupBy = people.GroupBy(p => p.Name);

            string s = "This is a test";
            Console.WriteLine(new string(s.Reverse().ToArray()));


            //var arr2 = new[] { 1, 2, 3, 4, 5 };
            //var arre = arr2.AsEnumerable(); // simply casts to IEnumerable<int>

            //var arr3 = new[] { 1, 3, 5, 7, 9 };
            //var arrf = arr2.AsEnumerable(); // simply casts to IEnumerable<int>



            var word1 = "helloooo";
            var word2 = "help";

            // distinct letters in helloooo
            Console.WriteLine(word1.Distinct());

            // letters in both word1 and word2
            var lettersInBoth = word1.Intersect(word2);
            Console.WriteLine(lettersInBoth);

            // letters in all words
            Console.WriteLine(word1.Union(word2));

            // letters in word1, but not in word1
            Console.WriteLine(word1.Except(word2));




            Console.ReadLine();
            // Console.WriteLine("Hello World!");
        }

    }
}
