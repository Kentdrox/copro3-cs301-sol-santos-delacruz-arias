namespace CharacterCreation
{
    internal interface MethodPlan
    {
        public string Name();
        public bool Answer();
        public string Gender();
        public string Color();
        public string HairLength();
        public string EyeType();
        public string SkinTone();
        public string BodyComposition();
        public string TopClothing(string gender);
        public string BottomClothing(string gender);
        public string NeckAccessories();
        public string WristAccessories();
        public string Earrings();
        public string Birthmarks();
        public string Tattoos();
        public string Shoes();
        public string PlayerClass();
        public string Job();
        public string UniqueSkill();
    }
}
