using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;

namespace Tasknator.Entities
{
    [Table("tasks", Schema = "mn_api")]
    public class TaskEntity
    {
        [Key]
        public int ID { get; set; }
        [Required(ErrorMessage = "O campo de Titulo da Tarefa deve ser preenchido")]
        public string Title { get; set; }
        [AllowNull]
        public string Description { get; set; }
        [Required(ErrorMessage = "O campo de Data Inicio da Tarefa deve ser preenchido")]
        public DateTime InitialDate { get; set; }
        [Required(ErrorMessage = "O campo de Data Estimada da Tarefa deve ser preenchido")]
        public DateTime EstimatedEndDate { get; set; }
        [AllowNull]
        public DateTime DeadLine { get; set; }
        [AllowNull]
        public bool Finished { get; set; }
        [AllowNull]
        public string DaysWeekToRepeat { get; set; }
    }
}
