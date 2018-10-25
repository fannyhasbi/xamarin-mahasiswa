using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace Kelompok06.Model
{
    class DataMahasiswa
    {
        [PrimaryKey]
        public int Id { get; set; }
        public string Nama { get; set; }
        public string Jurusan { get; set; }

        public override string ToString()
        {
            return "Name : " + this.Nama + " ==> Jurusan : " + this.Jurusan;
        }
    }
}
