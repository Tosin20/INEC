namespace INEC
{
    internal class INECAss
    {
        static void Main(string[] args)
        {


        
                SortedSet<string> voters = new SortedSet<string>();

                voters.Add("anu");               
                voters.Add("seun");
                voters.Add("anu");
                voters.Add("seun");
                voters.Add("peace");
                voters.Add("esther");
                voters.Add("anu");
                voters.Add("tola");
                voters.Add("grace");
                voters.Add("deborah");
                voters.Add("anu");
                voters.Add("tosin");


          



                Console.WriteLine("enter voter's name");
                string newName = Console.ReadLine();


                if (voters.Contains(newName))     //condition for existing user and new user
                {
                    Console.WriteLine("Voter already exists");
                }
                else
                {
                    voters.Add(newName);
                    Console.WriteLine("User successfully added");

                }
            }
        }
    }

  
    
