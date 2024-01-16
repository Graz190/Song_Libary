using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Song_Libary.Models
{
    internal class Song
    {
        public int Id { get; set; }
        public string SongName { get; set; }
        public string RecordName { get; set;}
        public int RecordNumber {  get; set;}
        public DateTime PublishDate { get; set; }
        public string ImageLink {  get; set; }
        public string BandName {  get; set; }

        public Song(int id, string songName, string recordName, int recordNumber, DateTime publishDate, string imageLink, string bandName)
        {
            Id = id;
            SongName = songName;
            RecordName = recordName;
            RecordNumber = recordNumber;
            PublishDate = publishDate;
            ImageLink = imageLink;
            BandName = bandName;
        }
    }
}
