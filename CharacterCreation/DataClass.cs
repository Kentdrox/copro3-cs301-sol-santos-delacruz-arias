using System.Data.SqlClient;

namespace CharacterCreation
{
    internal class DataClass : Database
    {
        SqlConnection connection;
        string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\kylle\source\repos\copro3-cs301-arias-santos-delacruz-sol\CharacterCreation\Database1.mdf;";
 //       string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Admin\source\repos\CharacterCreation\CharacterCreation\Database1.mdf;Integrated Security=True";
        public override void Insert(Character c)
        {
            try
            {   
                connection = new SqlConnection(connectionString);
                connection.Open();

                string insertQueryString = "INSERT INTO dbo.Character  VALUES('" +
                    c.Name + "','" + c.Gender + "','" + c.Hair_color + "','" + c.Hair_length + "','" +
                    c.Eye_type + "','" + c.Eye_color + "','" + c.Skin_tone + "','" + c.Body_composition + "','" +
                    c.Top_clothing + "','" + c.Top_clothing_color + "','" + c.Bottom_clothing + "','" +
                    c.Bottom_clothing_color + "','" + c.Neck_accessories + "','" + c.Wrist_accessories + "','" +
                    c.Earrings + "','" + c.Shoes + "','" + c.Birthmarks + "','" + c.Tattoos + "','" + c.Player_class +
                    "','" + c.Job + "','" + c.Unique_skill + "')";
                SqlCommand insertData = new SqlCommand(insertQueryString, connection);
                insertData.ExecuteNonQuery();
            }
            catch (Exception ex) { Console.WriteLine(ex.Message + "Hindi gumana"); }
        }
        public override void Display(Character c)
        {
            Console.WriteLine("Character summary:");
            Console.WriteLine($"    The character called {c.Name} is a {c.Gender} with a {c.Head}. " +
                $"The character has {c.Eye_color}, {c.Eye_type} eyes, \nhas a skin tone of {c.Skin_tone} and has a {c.Body_composition} body." +
                $" The character is wearing a {c.Top_clothing_color} {c.Top_clothing} with {c.Bottom_clothing_color} \n{c.Bottom_clothing}" +
                $" and {c.Shoes}." +
                $"\nAttributes: " +
                $"\nNeck accessories: {c.Neck_accessories}\nWrist accessories: {c.Wrist_accessories}\nEarrings: {c.Earrings}" +
                $"\nBirthmark: {c.Birthmarks}\nTattoos: {c.Tattoos}\nPlayer class: {c.Player_class}\nJob: {c.Job}\n" +
                $"Unique skill: {c.Unique_skill}\n");
        }
        public override void Display()
        {

            using (connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string query = "SELECT * FROM [dbo].[Character]";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Console.WriteLine();

                            Console.WriteLine($"Id:                     {reader["Id"]}");
                            Console.WriteLine($"Name:                   {reader["name"]}");
                            Console.WriteLine($"Gender:                 {reader["gender"]}");
                            Console.WriteLine($"Hair Color:             {reader["hair_color"]}");
                            Console.WriteLine($"Hair Length:            {reader["hair_length"]}");
                            Console.WriteLine($"Eye Type:               {reader["eye_type"]}");
                            Console.WriteLine($"Eye Color:              {reader["eye_color"]}");
                            Console.WriteLine($"Skin Tone:              {reader["skin_tone"]}");
                            Console.WriteLine($"Body Composition:       {reader["body_composition"]}");
                            Console.WriteLine($"Top Clothing:           {reader["top_clothing"]}");
                            Console.WriteLine($"Top Clothing Color:     {reader["top_clothing_color"]}");
                            Console.WriteLine($"Bottom Clothing:        {reader["bottom_clothing"]}");
                            Console.WriteLine($"Bottom Clothing Color:  {reader["bottom_clothing_color"]}");
                            Console.WriteLine($"Neck Accessories:       {reader["neck_accessories"]}");
                            Console.WriteLine($"Wrist Accessories:      {reader["wrist_accessories"]}");
                            Console.WriteLine($"Earrings:               {reader["earrings"]}");
                            Console.WriteLine($"Shoes:                  {reader["shoes"]}");
                            Console.WriteLine($"Birthmarks:             {reader["birthmarks"]}");
                            Console.WriteLine($"Tattoos:                {reader["tattoos"]}");
                            Console.WriteLine($"Player Class:           {reader["player_class"]}");
                            Console.WriteLine($"Job:                    {reader["job"]}");
                            Console.WriteLine($"Unique Skill:           {reader["unique_skill"]}");

                            Console.WriteLine();
                        }
                    }
                }
            }
        }
        public override void Delete()
        {
            int id = 0;
            Methods m = new Methods();
            bool ans = false;
            Console.Write("Enter ID to delete:          ");
            try {
                id = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Are you sure you want to delete?:        ");
                ans = m.Answer();

            }
            catch {
                Console.WriteLine("Invalid ID."); 
            }
            if (id <= 0) Console.WriteLine("ID cannot be negative or letters.");
            else if (!ID().Contains(id)) Console.WriteLine($"No character found with the id {id}.");
            else if(ans)
            using (connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string deleteQuery = $"DELETE FROM Character WHERE ID = {id}";
                using (SqlCommand command = new SqlCommand(deleteQuery, connection))
                {
                    command.Parameters.AddWithValue("@ID", id);

                    try
                    {
                        int rowsAffected = command.ExecuteNonQuery();
                        Console.WriteLine("Character deleted.");
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine($"No character found or error in ID.\n{ex.Message}");
                    }
                }
            }
        }
        public int[] ID()
        {
            List<int> ids = new List<int>();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string query = "SELECT [id] FROM [dbo].[Character]";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            int id = Convert.ToInt32(reader["id"].ToString());
                            ids.Add(id);
                        }
                    }
                }

            }
            return ids.ToArray();
        }
        public string[] Names()
        {
            List<string> names = new List<string>();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string query = "SELECT [name] FROM [dbo].[Character]";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string name = reader["name"].ToString();
                            names.Add(name);
                        }
                    }
                }

            }
            return names.ToArray();
        }



    }
}
