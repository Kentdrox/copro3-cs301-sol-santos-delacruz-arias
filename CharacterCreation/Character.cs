namespace CharacterCreation
{
    public struct Character
    {
        private string name, gender, hair_color, hair_length, head, eye_type,
            eye_color, skin_tone, body_composition, top_clothing, top_clothing_color,
            bottom_clothing, bottom_clothing_color, neck_accessories, wrist_accessories, earrings,
            shoes, birthmarks, tattoos, player_class, job,unique_skill;

        public Character(string name, string gender, string hair_color, string hair_length, string head, string eye_type,
            string eye_color, string skin_tone, string body_composition, string top_clothing, string top_clothing_color,
            string bottom_clothing, string bottom_clothing_color, string neck_accessories, string wrist_accessories,
            string earrings, string shoes, string birthmarks, string tattoos, string player_class, string job,
            string unique_skill)
        {
            this.name = name; this.gender = gender; this.hair_color = hair_color; this.hair_length = hair_length;
            this.eye_type = eye_type; this.eye_color = eye_color; this.skin_tone = skin_tone; this.head = head;
            this.body_composition = body_composition; this.top_clothing = top_clothing; 
            this.top_clothing_color = top_clothing_color; this.bottom_clothing = bottom_clothing;
            this.bottom_clothing_color = bottom_clothing_color; this.neck_accessories = neck_accessories;
            this.wrist_accessories = wrist_accessories; this.earrings = earrings; this.shoes = shoes;
            this.birthmarks = birthmarks; this.tattoos = tattoos; this.player_class = player_class;
            this.job = job; this.unique_skill = unique_skill;
        }
        public string Name { get { return name; } }
        public string Gender { get { return gender; } }
        public string Hair_color { get {  return hair_color; } }
        public string Hair_length { get { return hair_length; } }
        public string Head {  get { return head; } }
        public string Eye_type {  get { return eye_type; } }
        public string Eye_color {  get { return eye_color; } }
        public string Skin_tone {  get { return skin_tone; } }
        public string Body_composition { get { return body_composition; } }
        public string Top_clothing {  get { return top_clothing; } }
        public string Top_clothing_color { get { return top_clothing_color; } }
        public string Bottom_clothing { get { return bottom_clothing; } }
        public string Bottom_clothing_color { get { return bottom_clothing_color; } }
        public string Neck_accessories { get { return neck_accessories; } }
        public string Wrist_accessories { get { return wrist_accessories; } }  
        public string Earrings { get { return earrings; } }
        public string Shoes { get { return shoes; } }  
        public string Birthmarks { get { return birthmarks; } }
        public string Tattoos { get { return tattoos; } }
        public string Player_class {  get { return player_class; } }
        public string Job { get { return job; } }
        public string Unique_skill { get { return unique_skill; } } 


    }
}
