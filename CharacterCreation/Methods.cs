namespace CharacterCreation
{
    internal class Methods : MethodPlan
    {
        int value = 0;
        string stringValue = "";
        static int xValue = 0;
        static string xStringValue = "";
        DataClass dc = new DataClass();
        public string Name()
        {
            bool stop = false;
            while (!stop)
            {
                try
                {
                    Console.Write("Enter your name:     ");
                    stringValue = Console.ReadLine().ToLower();
                    if (stringValue.Length == 0) Console.WriteLine("Character name must not be empty.");
                    else if (dc.Names().Contains(stringValue)) Console.WriteLine("Character already exists, please try again.");
                    else break;
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
            return stringValue;
        }
        public bool Answer()
        {
            bool stop = false;
            bool answer = true;
            while (!stop)
            {
                try
                {
                    Console.Write("(1-2):           ");
                    stringValue = Console.ReadLine();
                    stringValue = stringValue.ToLower();
                    if (stringValue == "1")
                    {
                        answer = true;
                        break;
                    }
                    if (stringValue == "2")
                    {
                        answer = false;
                        break;
                    }
                    Console.WriteLine("Try again (1-2).");
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
            return answer;
        }
        public static int Menu()
        {
            bool stop = false;
            while (!stop)
            {
                try
                {
                    Console.Write("Choose (1-4):        ");
                    xStringValue = Console.ReadLine();
                    xValue = Convert.ToInt32(xStringValue);
                    if (xValue >= 1 && xValue <= 4) stop = true;
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
            return xValue;
        }
        public string Gender()
        {
            bool stop = false;
            while (!stop)
            {
                try
                {
                    Console.Write("Choose (1-2):        ");
                    stringValue = Console.ReadLine();
                    value = Convert.ToInt32(stringValue);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
                finally
                {
                    if (value == 1) stringValue = "male";
                    if (value == 2) stringValue = "female";
                    if (value >= 1 && value <= 2) stop = true;
                }
            }
            return stringValue;
        }
        
        public string Color()
        {
            bool stop = false;
            while (!stop)
            {
                try
                {
                    Console.Write("Choose (1-5):        ");
                    stringValue = Console.ReadLine();
                    value = Convert.ToInt32(stringValue);
                    if (value >= 1 && value <= 5) stop = true;
                    switch (value)
                    {
                        case 1:
                            stringValue = "black";
                            break;
                        case 2:
                            stringValue = "white";
                            break;
                        case 3:
                            stringValue = "red";
                            break;
                        case 4:
                            stringValue = "pink";
                            break;
                        case 5:
                            stringValue = "blue";
                            break;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
            return stringValue;
        }
        public string HairLength()
        {
            bool stop = false;
            while (!stop)
            {
                try
                {
                    Console.Write("Choose (1-4):        ");
                    stringValue = Console.ReadLine();
                    value = Convert.ToInt32(stringValue);
                    switch (value)
                    {
                        case 1:
                            stringValue = "long";
                            break;
                        case 2:
                            stringValue = "short";
                            break;
                        case 3:
                            stringValue = "shoulder length";
                            break;
                        case 4:
                            stringValue = "chin length";
                            break;
                    }
                    if (value >= 1 && value <= 4) stop = true;
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
            return stringValue;
        }
        public string EyeType()
        {
            bool stop = false;
            while (!stop)
            {
                try
                {
                    Console.Write("Choose (1-4):        ");
                    stringValue = Console.ReadLine();
                    value = Convert.ToInt32(stringValue);
                    switch (value)
                    {
                        case 1:
                            stringValue = "almond";
                            break;
                        case 2:
                            stringValue = "round";
                            break;
                        case 3:
                            stringValue = "asian";
                            break;
                        case 4:
                            stringValue = "protruding";
                            break;
                    }
                    if (value >= 1 && value <= 4) stop = true;
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
            return stringValue;
        }
        public string SkinTone()
        {
            bool stop = false;
            while (!stop)
            {
                try
                {
                    Console.Write("Choose (1-5):        ");
                    stringValue = Console.ReadLine();
                    value = Convert.ToInt32(stringValue);
                    switch (value)
                    {
                        case 1:
                            stringValue = "kayumanggi";
                            break;
                        case 2:
                            stringValue = "tan";
                            break;
                        case 3:
                            stringValue = "white";
                            break;
                        case 4:
                            stringValue = "yellow";
                            break;
                        case 5:
                            stringValue = "black";
                            break;
                    }
                    if (value >= 1 && value <= 5) stop = true;
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
            return stringValue;
        }
        public string BodyComposition()
        {
            bool stop = false;
            while (!stop)
            {
                try
                {
                    Console.Write("Choose (1-4):        ");
                    stringValue = Console.ReadLine();
                    value = Convert.ToInt32(stringValue);
                    switch (value)
                    {
                        case 1:
                            stringValue = "fat";
                            break;
                        case 2:
                            stringValue = "lean";
                            break;
                        case 3:
                            stringValue = "bulk";
                            break;
                        case 4:
                            stringValue = "slim";
                            break;
                    }
                    if (value >= 1 && value <= 4) stop = true;
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
            return stringValue;
        }
        public string TopClothing(string gender)
        {
            Console.WriteLine("Choose top clothing:");
            bool stop = false;
            while (!stop)
            {
               if(gender == "male")
                {
                    Console.WriteLine("1. Suit\n2. Jacket\n3. T-Shirt\n4. Topless");
                    while (!stop)
                    {
                        try
                        {
                            Console.Write("Choose (1-4):        ");
                            value = Convert.ToInt32(Console.ReadLine());
                            switch (value)
                            {
                                case 1:
                                    stringValue = "suit";
                                    break;
                                case 2:
                                    stringValue = "jacket";
                                    break;
                                case 3:
                                    stringValue = "t-shirt";
                                    break;
                                case 4:
                                    stringValue = "topless";
                                    break;
                            }
                            if (value >= 1 && value <= 4) stop = true;
                        }
                        catch(Exception e)
                        {
                            Console.WriteLine(e.Message);
                        }
                    }
                }
                if (gender == "female")
                {
                    Console.WriteLine("1. Crop top\n2. Back less\n3. Tank top\n4. Shoulder less");
                    while (!stop)
                    {
                        try
                        {
                            Console.Write("Choose (1-4):        ");
                            value = Convert.ToInt32(Console.ReadLine());
                            switch (value)
                            {
                                case 1:
                                    stringValue = "crop top";
                                    break;
                                case 2:
                                    stringValue = "back less";
                                    break;
                                case 3:
                                    stringValue = "tank top";
                                    break;
                                case 4:
                                    stringValue = "shoulder less";
                                    break;
                            }
                            if (value >= 1 && value <= 4) stop = true;
                        }
                        catch (Exception e)
                        {
                            Console.WriteLine(e.Message);
                        }
                    }
                }
            }
            return stringValue;
        }
        public string BottomClothing(string gender)
        {
            Console.WriteLine("Choose bottom clothing:");
            bool stop = false;
            while (!stop)
            {
                if (gender == "male")
                {
                    Console.WriteLine("1. Shorts\n2. Slacks\n3. Jeans\n4. Jogging pants");
                    while (!stop)
                    {
                        try
                        {
                            Console.Write("Choose (1-4):        ");
                            value = Convert.ToInt32(Console.ReadLine());
                            switch (value)
                            {
                                case 1:
                                    stringValue = "shorts";
                                    break;
                                case 2:
                                    stringValue = "slacks";
                                    break;
                                case 3:
                                    stringValue = "jeans";
                                    break;
                                case 4:
                                    stringValue = "jogging pants";
                                    break;
                            }
                            if (value >= 1 && value <= 4) stop = true;
                        }
                        catch (Exception e)
                        {
                            Console.WriteLine(e.Message);
                        }
                    }
                }
                if (gender == "female")
                {
                    Console.WriteLine("1. Shorts\n2. Skirt\n3. Ripped jeans\n4. Sweatpants");
                    while (!stop)
                    {
                        try
                        {
                            Console.Write("Choose (1-4):        ");
                            value = Convert.ToInt32(Console.ReadLine());
                            switch (value)
                            {
                                case 1:
                                    stringValue = "shorts";
                                    break;
                                case 2:
                                    stringValue = "skirt";
                                    break;
                                case 3:
                                    stringValue = "ripped jeans";
                                    break;
                                case 4:
                                    stringValue = "sweatpants";
                                    break;
                            }
                            if (value >= 1 && value <= 4) stop = true;
                        }
                        catch (Exception e)
                        {
                            Console.WriteLine(e.Message);
                        }
                    }
                } 
            }
            return stringValue;
        }
        public string NeckAccessories()
        {
            bool stop = false;
            Console.WriteLine("Choose neck accessories:\n1. Necklace\n2. Scarf\n3. Choker\n4. Amulet");
            while (!stop)
            {
                try
                {
                    Console.Write("Choose (1-4):        ");
                    stringValue = Console.ReadLine();
                    value = Convert.ToInt32(stringValue);
                    switch (value)
                    {
                        case 1:
                            stringValue = "necklace";
                            break;
                        case 2:
                            stringValue = "scarf";
                            break;
                        case 3:
                            stringValue = "choker";
                            break;
                        case 4:
                            stringValue = "amulet";
                            break;
                    }
                    if (value >= 1 && value <= 4) stop = true;
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
            return stringValue;
        }
        public string WristAccessories()
        {
            bool stop = false;
            Console.WriteLine("Choose wrist accessories:\n1. Watch\n2. Chain\n3. Omnitrix\n4. Bracelet");
            while (!stop)
            {
                try
                {
                    Console.Write("Choose (1-4):        ");
                    stringValue = Console.ReadLine();
                    value = Convert.ToInt32(stringValue);
                    switch (value)
                    {
                        case 1:
                            stringValue = "watch";
                            break;
                        case 2:
                            stringValue = "chain";
                            break;
                        case 3:
                            stringValue = "omnitrix";
                            break;
                        case 4:
                            stringValue = "bracelet";
                            break;
                    }
                    if (value >= 1 && value <= 4) stop = true;
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
            return stringValue;
        }
        public string Earrings()
        {
            bool stop = false;
            Console.WriteLine("Choose earrings:\n1. Gold\n2. Silver\n3. Diamond\n4. Obsidian");
            while (!stop)
            {
                try
                {
                    Console.Write("Choose (1-4):        ");
                    stringValue = Console.ReadLine();
                    value = Convert.ToInt32(stringValue);
                    switch (value)
                    {
                        case 1:
                            stringValue = "gold";
                            break;
                        case 2:
                            stringValue = "silver";
                            break;
                        case 3:
                            stringValue = "diamond";
                            break;
                        case 4:
                            stringValue = "obsidian";
                            break;
                    }
                    if (value >= 1 && value <= 4) stop = true;
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
            return stringValue += " earrings";
        }
        public string Birthmarks()
        {
            bool stop = false;
            Console.WriteLine("Choose birthmark:\n1. Dragonborne\n2. Snakeborne\n3. Lionborne\n4. Big dipper");
            while (!stop)
            {
                try
                {
                    Console.Write("Choose (1-4):        ");
                    stringValue = Console.ReadLine();
                    value = Convert.ToInt32(stringValue);
                    switch (value)
                    {
                        case 1:
                            stringValue = "dragonborne";
                            break;
                        case 2:
                            stringValue = "snakeborne";
                            break;
                        case 3:
                            stringValue = "lionborne";
                            break;
                        case 4:
                            stringValue = "big dipper";
                            break;
                    }
                    if (value >= 1 && value <= 4) stop = true;
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
            return stringValue;
        }
        public string Tattoos()
        {
            bool stop = false;
            Console.WriteLine("Choose tattoo:\n1. Japanese\n2. Realism\n3. Geometric\n4. New school");
            while (!stop)
            {
                try
                {
                    Console.Write("Choose (1-4):        ");
                    stringValue = Console.ReadLine();
                    value = Convert.ToInt32(stringValue);
                    switch (value)
                    {
                        case 1:
                            stringValue = "japanese";
                            break;
                        case 2:
                            stringValue = "realism";
                            break;
                        case 3:
                            stringValue = "geometric";
                            break;
                        case 4:
                            stringValue = "new school";
                            break;
                    }
                    if (value >= 1 && value <= 4) stop = true;
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
            return stringValue += " tatoo";
        }
        public string Shoes()
        {
            bool stop = false;
            while (!stop)
            {
                try
                {
                    Console.Write("Choose (1-5):        ");
                    stringValue = Console.ReadLine();
                    value = Convert.ToInt32(stringValue);
                    switch (value)
                    {
                        case 1:
                            stringValue = "sports shoes";
                            break;
                        case 2:
                            stringValue = "casual shoes";
                            break;
                        case 3:
                            stringValue = "leather shoes";
                            break;
                        case 4:
                            stringValue = "sandals";
                            break;
                        case 5:
                            stringValue = "flipflops";
                            break;
                    }
                    if (value >= 1 && value <= 5) stop = true;
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
            return stringValue;
        }
        public string PlayerClass()
        {
            bool stop = false;
            while (!stop)
            {
                try
                {
                    Console.Write("Choose (1-5):        ");
                    stringValue = Console.ReadLine();
                    value = Convert.ToInt32(stringValue);
                    switch (value)
                    {
                        case 1:
                            stringValue = "mage";
                            break;
                        case 2:
                            stringValue = "tank";
                            break;
                        case 3:
                            stringValue = "fighter";
                            break;
                        case 4:
                            stringValue = "assassin";
                            break;
                        case 5:
                            stringValue = "support";
                            break;
                    }
                    if (value >= 1 && value <= 5) stop = true;
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
            return stringValue;
        }
        public string Job()
        {
            bool stop = false;
            while (!stop)
            {
                try
                {
                    Console.Write("Choose (1-5):        ");
                    stringValue = Console.ReadLine();
                    value = Convert.ToInt32(stringValue);
                    switch (value)
                    {
                        case 1:
                            stringValue = "chef";
                            break;
                        case 2:
                            stringValue = "smith";
                            break;
                        case 3:
                            stringValue = "merchant";
                            break;
                        case 4:
                            stringValue = "software engineer";
                            break;
                        case 5:
                            stringValue = "architect";
                            break;
                    }
                    if (value >= 1 && value <= 5) stop = true;
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
            return stringValue;
        }
        public string UniqueSkill()
        {
            bool stop = false;
            while (!stop)
            {
                try
                {
                    Console.Write("Choose (1-4):        ");
                    stringValue = Console.ReadLine();
                    value = Convert.ToInt32(stringValue);
                    switch (value)
                    {
                        case 1:
                            stringValue = "fourth wall";
                            break;
                        case 2:
                            stringValue = "true omnipotence";
                            break;
                        case 3:
                            stringValue = "regressor";
                            break;
                        case 4:
                            stringValue = "dimension manipulation";
                            break;
                    }
                    if (value >= 1 && value <= 4) stop = true;
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
            return stringValue;
        }



    }
}
