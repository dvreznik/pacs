using System;
using System.ComponentModel.DataAnnotations;

namespace PACS.Models
{
    public class GymCard
    {
        /// <summary>
        /// GymCard class contain all information about type of card and it's owner
        /// </summary>
        // auto increment filed for count
        public int GymCardId { get; set; }
        // if trainer support
        public bool Tainer { get; set; }        
        public DateTime DateOrder { get; set; }
        public DateTime ExpirationDate { get; set; }
        // 
        public Kind Kind { get; set; }
        // owner of card
        public int GymMemberId { get; set; }
        // if card is available
        public bool Visible { get; set; }
       
    }

    public enum Kind
    {
        [Display(Name = "Student")]
        Student,
        [Display(Name = "8 Times")]
        Times_8,
        [Display(Name = "12 Times")]
        Times_12,
        [Display(Name = "16 Times")]
        Times_16,
        [Display(Name = "20 Times")]
        Times_20,
        [Display(Name = "1 Month")]
        Month_1,
        [Display(Name = "3 Month")]
        Month_3,
        [Display(Name = "6 Month")]
        Month_6,
        [Display(Name = "Year")]
        Year
    }       
}