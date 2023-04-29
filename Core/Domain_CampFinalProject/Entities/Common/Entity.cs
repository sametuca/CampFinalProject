namespace Domain_CampFinalProject.Entities.Common
{
    public class Entity
    {
        public int Id { get; set; }
        public DateTime? CreatedDate { get; set; }
        virtual public DateTime? UpdatedDate { get; set; }
    }
}
