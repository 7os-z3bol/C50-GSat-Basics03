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
        StringBuilder sb = new StringBuilder();
        sb.Append("Book List");
        Console.WriteLine(sb);
        sb.Append("_ Updated");
        Console.WriteLine(sb);

        #region q4
        sb.Replace("Book List", "Library");
        Console.WriteLine(sb);
        #endregion
        #endregion


    }
}