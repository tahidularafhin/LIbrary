using System.ComponentModel.DataAnnotations;

namespace LibraryData.Models
{
    public  class Video: LibraryAsset
    {
        //LibraryAsset descriminator column is Book and Video
        [Required]
        public string Director { get; set; }
    }
}
