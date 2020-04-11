namespace eUseControl.Web.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class UDbTable
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(30)]
        public string username { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(50)]
        public string password { get; set; }

        [Key]
        [Column(Order = 3)]
        [StringLength(30)]
        public string email { get; set; }

        [Key]
        [Column(Order = 4)]
        public DateTime LastLogin { get; set; }

        [Key]
        [Column(Order = 5)]
        [StringLength(30)]
        public string LasIp { get; set; }

        [Key]
        [Column(Order = 6)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Level { get; set; }
    }
}
