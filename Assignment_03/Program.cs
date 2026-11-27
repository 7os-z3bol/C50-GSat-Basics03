using System.Text;

class Program
{
    static void Main(string[] args)
    {
        #region Q1

        //string title = "clean code";
        //Console.WriteLine(title);
        //string upperrTitle = title.ToUpper();
        //Console.WriteLine(upperrTitle);
        #endregion

        #region Q2
        //string x = "clean code";
        //string y = "clean code";
        //Console.WriteLine(x.Equals(y)); 
        #endregion

        #region Q3
        //StringBuilder sb = new StringBuilder();
        //sb.Append("Book List");
        //Console.WriteLine(sb);
        //sb.Append("_ Updated");
        //Console.WriteLine(sb);

        #region q4
        //sb.Replace("Book List", "Library");
        //Console.WriteLine(sb);
        #endregion
        #endregion

        #region Q5, Q6, Q7
        //string title = "Clean Code";
        //int pages = 464;

        //string result = "Book: " + title + ", Pages: " + pages;
        //Console.WriteLine(result);

        // Question 6
        //Console.WriteLine($"Book: {title}, Pages: {pages}");

        // Question 7
        //string result = string.Format("Book : {0} , Pages : {1} ,", title, pages);

        #endregion

        #region Q8

        //int Pages = 464;
        //if (pages > 300)
        //{
        //    Console.WriteLine("Long Book");
        //}
        //else
        //{
        //    Console.WriteLine("Short Book");
        //}


        #endregion

        #region Q9
        //int Pages = 464;
        //bool isAvaiable = true;

        //if (Pages > 300 && isAvaiable == true)
        //{
        //    Console.WriteLine("You can borrow this book");
        //}
        //else
        //{
        //    Console.WriteLine(" Not Avilable");
        //}

        #endregion

        #region Q10
        //string title = "Refactoring";
        //switch (title)
        //{

        //    case "Clean code":
        //        Console.WriteLine("Great choice!");
        //        break;
        //    case "Refactoring":
        //        Console.WriteLine("Nice Pick!");
        //        break;

        //    default:
        //        Console.WriteLine("Never heard of it.");
        //        break; 
        //}
        #endregion

        #region Q11
        //int Pages = 464;
        //string sizelable = (Pages > 300) ? "Long Book" : "Short Book";
        //Console.WriteLine(sizelable);
        #endregion

        #region Q12
        string[] Books = { "Clean Code", "Refactoring", "The Pragmatic Programmer" };
        for(int i =0; i < Books.Length; i++)
        {
            Console.WriteLine((i +1) + ". " + Books[i]);
            
        }
        #endregion

    }



    }
