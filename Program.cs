
class cs60d
{


    public static void Main() { 
    
        Console.BackgroundColor = ConsoleColor.White;
        Console.ForegroundColor= ConsoleColor.Black;
        Console.Clear();
        while (true)
        {
            double d = 360.00;
            double dd = 60.00;
            double ddd = d / dd;
            double d1 = 2.00 * Math.PI;
            double d2 = d1 / dd;
            string s = "";
            string ss = "";
            int i = 0;

            Console.BackgroundColor = ConsoleColor.White;

            Console.ForegroundColor = ConsoleColor.Black;
            Console.Clear();
            var input = "";// Console.ReadLine();
            for (i = 0; i < 17; i++)
            {
                s = ((double)i * ddd).ToString();
                if (s.Length > 6)
                {
                    ss = s.Substring(0, 6);
                    ss = ss + "                                                                                        ";
                    ss = ss.Substring(0, 16);
                }
                else
                {

                    ss = s;
                    ss = ss + "                                                                                        ";
                    ss = ss.Substring(0, 16);

                }
                s = (Math.Cos((double)i * d2)).ToString();
                if (s.Length > 6)
                {
                    s = s.Substring(0, 6);
                    s = s + "                                                                                        ";
                    s = s.Substring(0, 16);
                }
                else
                {
                    s = s;
                    s = s + "                                                                                        ";
                    s = s.Substring(0, 16);

                }
                ss = ss + s;
                s = (Math.Sin((double)i * d2)).ToString();
                if (s.Length > 6)
                {
                    s = s.Substring(0, 6);
                    s = s + "                                                                                        ";
                    s = s.Substring(0, 16);
                }
                else
                {
                    s = s;
                    s = s + "                                                                                        ";
                    s = s.Substring(0, 16);

                }
                ss = ss + s;
                Console.WriteLine(ss);
                ss = "";
            }
            input = Console.ReadLine();
            for (i = 16; i < 32; i++)
            {
                s = ((double)i * ddd).ToString();
                if (s.Length > 6)
                {
                    ss = s.Substring(0, 6);
                    ss = ss + "                                                                                        ";
                    ss = ss.Substring(0, 16);
                }
                else
                {

                    ss = s;
                    ss = ss + "                                                                                        ";
                    ss = ss.Substring(0, 16);

                }
                s = (Math.Cos((double)i * d2)).ToString();
                if (s.Length > 6)
                {
                    s = s.Substring(0, 6);
                    s = s + "                                                                                        ";
                    s = s.Substring(0, 16);
                }
                else
                {
                    s = s;
                    s = s + "                                                                                        ";
                    s = s.Substring(0, 16);

                }
                ss = ss + s;
                s = (Math.Sin((double)i * d2)).ToString();
                if (s.Length > 6)
                {
                    s = s.Substring(0, 6);
                    s = s + "                                                                                        ";
                    s = s.Substring(0, 16);
                }
                else
                {
                    s = s;
                    s = s + "                                                                                        ";
                    s = s.Substring(0, 16);

                }
                ss = ss + s;
                Console.WriteLine(ss);
                ss = "";
            }
            input = Console.ReadLine();

            for (i = 32; i < 32 + 16; i++)
            {
                s = ((double)i * ddd).ToString();
                if (s.Length > 6)
                {
                    ss = s.Substring(0, 6);
                    ss = ss + "                                                                                        ";
                    ss = ss.Substring(0, 16);
                }
                else
                {

                    ss = s;
                    ss = ss + "                                                                                        ";
                    ss = ss.Substring(0, 16);

                }
                s = (Math.Cos((double)i * d2)).ToString();
                if (s.Length > 6)
                {
                    s = s.Substring(0, 6);
                    s = s + "                                                                                        ";
                    s = s.Substring(0, 16);
                }
                else
                {
                    s = s;
                    s = s + "                                                                                        ";
                    s = s.Substring(0, 16);

                }
                ss = ss + s;
                s = (Math.Sin((double)i * d2)).ToString();
                if (s.Length > 6)
                {
                    s = s.Substring(0, 6);
                    s = s + "                                                                                        ";
                    s = s.Substring(0, 16);
                }
                else
                {
                    s = s;
                    s = s + "                                                                                        ";
                    s = s.Substring(0, 16);

                }
                ss = ss + s;
                Console.WriteLine(ss);
                ss = "";
            }
            input = Console.ReadLine();


            for (i = 32 + 16; i < 32 + 16 + 16 - 3; i++)
            {
                s = ((double)i * ddd).ToString();
                if (s.Length > 6)
                {
                    ss = s.Substring(0, 6);
                    ss = ss + "                                                                                        ";
                    ss = ss.Substring(0, 16);
                }
                else
                {

                    ss = s;
                    ss = ss + "                                                                                        ";
                    ss = ss.Substring(0, 16);

                }
                s = (Math.Cos((double)i * d2)).ToString();
                if (s.Length > 6)
                {
                    s = s.Substring(0, 6);
                    s = s + "                                                                                        ";
                    s = s.Substring(0, 16);
                }
                else
                {
                    s = s;
                    s = s + "                                                                                        ";
                    s = s.Substring(0, 16);

                }
                ss = ss + s;
                s = (Math.Sin((double)i * d2)).ToString();
                if (s.Length > 6)
                {
                    s = s.Substring(0, 6);
                    s = s + "                                                                                        ";
                    s = s.Substring(0, 16);
                }
                else
                {
                    s = s;
                    s = s + "                                                                                        ";
                    s = s.Substring(0, 16);

                }
                ss = ss + s;
                Console.WriteLine(ss);
                ss = "";
            }
            input = Console.ReadLine();
        }



    }


}