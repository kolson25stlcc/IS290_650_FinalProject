using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations; //Namespace is used to add propery level attributes
using System.Diagnostics.CodeAnalysis;

namespace SampleDemo.Models
{
    public class Album
    {
        [Required(ErrorMessage = "Album Id is required.")]
        public int AlbumID { get; set; }

        //[Required(ErrorMessage ="Album Name is required.")]
        [AllowNull]
        public string AlbumName { get; set; }

        //[Required(ErrorMessage ="Year is required.")]
        [AllowNull]
        [DataType(DataType.Date)]
        public DateTime? Year { get; set; }

        //[Required(ErrorMessage="Genre is required.")]
        [AllowNull]
        public string Genre { get; set; }




    }
}