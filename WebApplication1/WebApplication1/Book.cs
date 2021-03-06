using System;
using Appeon.CoreService.Data;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplication1
{
    [Table("book")]
    [SqlParameter("ids",typeof(Int32))]
    [SqlWhere("id<=:ids")]
    public class Book
    {
        [Key]
        [Identity]
        [SqlColumn("Id")]
        public Int32 Id { get; set; }

        [SqlColumn("Name")]
        public String Name { get; set; }

        [SqlColumn("Type")]
        public Int16 Type { get; set; }

        [SqlColumn("Price")]
        public Decimal Price { get; set; }

        [SqlColumn("ActTime")]
        public TimeSpan Acttime { get; set; }

        [SqlColumn("InDate")]
        public DateTime Indate { get; set; }

        [SqlColumn("CreateTime")]
        public DateTime Createtime { get; set; }

        [SqlColumn("UpdateTime")]
        public DateTime Updatetime { get; set; }

        [SqlColumn("Remark")]
        public String Remark { get; set; }

        [SqlColumn("Deleted")]
        public Boolean Deleted { get; set; }
    }
}
