namespace RCJaxWebApi.Models
{
    public class EncounterMaterial : BaseModel
    {
        public int EncounterMaterialId { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public float Cost { get; set; }
        public string Link { get; set; }
    }
}
