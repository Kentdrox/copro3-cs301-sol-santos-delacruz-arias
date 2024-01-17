namespace CharacterCreation
{
    internal class Game : Methods
    {
        public Game() 
        {
            bool answer;
            
            string name = Name();

            Console.WriteLine("What is your gender?\n1. Male\n2. Female");
            string gender = Gender();

            Console.WriteLine("Do you have hair?\n1. Yes\n2. No");
            answer = Answer();
            string hair_color = ""; string hair_length = ""; string head = "";
            if (answer)
            {
                Console.WriteLine("What is your hair color?" +
                "\n1. Black\n2. White\n3. Red\n4. Pink\n5. Blue");
                hair_color = Color();

                Console.WriteLine("What is your hair length?" +
                    "\n1. Long\n2. Short\n3. Shoulder length\n4. Chin length");
                hair_length = HairLength();
                head = $"{hair_length}, {hair_color} hair";
            }
            else
            {
                head = "bald head";
                hair_color = "none";
                hair_length = "none";
            }

            Console.WriteLine("What is your eye type?" +
                "\n1. Almond\n2. Round\n3. Asian\n4. Protruding ");
            string eye_type = EyeType();

            Console.WriteLine("What is your eye color?" +
                "\n1. Black\n2. White\n3. Red\n4. Pink\n5. Blue");
            string eye_color = Color();

            Console.WriteLine("What is your skin tone?" +
                "\n1. Kayumanggi\n2. Tan\n3. White\n4. Yellow\n5. Black");
            string skin_tone = SkinTone();

            Console.WriteLine("What is your body composition?" +
                "\n1. Fat\n2. Lean\n3. Bulk\n4. Slim");
            string body_composition = BodyComposition();

            string top_clothing = TopClothing(gender);

            Console.WriteLine("What is your top clothing color?" +
                "\n1. Black\n2. White\n3. Red\n4. Pink\n5. Blue");
            string top_clothing_color = Color();

            string bottom_clothing = BottomClothing(gender);

            Console.WriteLine("What is your bottom clothing color?" +
                "\n1. Black\n2. White\n3. Red\n4. Pink\n5. Blue");
            string bottom_clothing_color = Color();

            Console.WriteLine("Do you have neck accessories?\n1. Yes\n2. No");
            answer = Answer(); string neck_accessories = "";
            if (!answer) neck_accessories = "none";
            if(answer) neck_accessories = NeckAccessories();

            Console.WriteLine("Do you have wrist accessories?\n1. Yes\n2. No");
            answer = Answer(); string wrist_accessories = "";
            if (!answer) wrist_accessories = "none";
            if (answer) wrist_accessories = WristAccessories();

            Console.WriteLine("Do you have earrings?\n1. Yes\n2. No");
            answer = Answer(); string earrings = "";
            if (!answer) earrings = "none";
            if (answer) earrings = Earrings();

            Console.WriteLine("Do you have birthmarks?\n1. Yes\n2. No");
            answer = Answer(); string birthmarks = "";
            if (!answer) birthmarks = "none";
            if (answer) birthmarks = Birthmarks();

            Console.WriteLine("Do you have tattoos?\n1. Yes\n2. No");
            answer = Answer(); string tattoos = "";
            if (!answer) tattoos = "none";
            if (answer) tattoos = Tattoos();

            Console.WriteLine("What is your shoe?" +
                "\n1. Sports shoes\n2. Casual shoes\n3. Leather shoes\n4. Sandals\n5. Flipflops");
            string shoes = Shoes();

            Console.WriteLine("What is your player class?" +
                "\n1. Mage\n2. Tank\n3. Fighter\n4. Assassin\n5. Support");
            string player_class = PlayerClass();

            Console.WriteLine("What is your job (subclass)?" +
                "\n1. Chef\n2. Smith\n3. Merchant\n4. Software engineer\n5. Architect");
            string job = Job();

            Console.WriteLine("What is your unique skill?" +
                "\n1. Fourth wall\n2. True omnipotence\n3. Regressor\n4. Dimension Manipulation");
            string unique_skill = UniqueSkill();

            Character character = new Character(name, gender, hair_color, hair_length, head, eye_type,
            eye_color, skin_tone, body_composition, top_clothing, top_clothing_color,
            bottom_clothing, bottom_clothing_color, neck_accessories, wrist_accessories, earrings,
            shoes, birthmarks, tattoos, player_class, job, unique_skill);
 
            DataClass dataClass = new DataClass();
            dataClass.Display(character);
            Console.WriteLine("Create character?\n1. Yes\n2. No");
            answer = Answer();
            if (answer)
            {
                dataClass.Insert(character);
                Console.WriteLine("Character created!");
            }
            if (!answer) Console.WriteLine("Character discarded.");
        }
        

    }
}
