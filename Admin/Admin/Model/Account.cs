namespace Admin
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;
    using Admin.Model;

    [Table("Account")]
    public partial class Account
    {
        public int MaQT { get; set; }
        public string HoTen { get; set; }
        public string MatKhau { get; set; }
        public string SDT { get; set; }
        public ROLE Roles { get; set; }

    }
}
