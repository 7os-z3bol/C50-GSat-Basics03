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

        #region Q5, Q6
        string title = "Clean Code";
        int pages = 464;

        //string result = "Book: " + title + ", Pages: " + pages;
        //Console.WriteLine(result);

        // Question 6
        //Console.WriteLine($"Book: {title}, Pages: {pages}");

        // Question 7
        string result = string.Format("Book : {0} , Pages : {1} ,", title, pages);
        
        #endregion





    }
}