// See https://aka.ms/new-console-template for more information

class Program
{
    public delegate double MyRounder(double d, int n);
    static void Main(string[] args)
    {
        // create variable of delegate function type 
        MyRounder myRounder;

        // your code here
        

        // expressions for MyRounder delegate

        myRounder = (d, n) => Math.Round(d, n); // Solution 1

        myRounder = Math.Round; // Solution 2

        myRounder = (double d, int n) => Math.Round(d, n); // Solution 3

        myRounder = (d, n) => Math.Round(d, n); // Solution 4

        myRounder = (double d, int n) => { return Math.Round(d, n); }; // Solution 5

        myRounder = delegate (double d, int n) { return Math.Round(d, n); }; // Solution 6

        myRounder = (d, n) => { return Math.Round(d, n); }; // Solution 7

        myRounder = (double d, int n) => Math.Round(d, n); // Solution 8



        
    }
}
