using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace exam_912.Models
{
    public class Exam
    {
        [Key]
        public int ExamId { get; set; }
        public ExamSubject1 ExamSubject { get; set; }
        public string StartTime { get; set; }
        public DateTime ExamDate { get; set; }
        public int ExamDuration { get; set; }
        public ClassRoomSt ClassRoom { get; set; }
        public Teacher Faculty { get; set; }
        public ExamStatus Status { get; set; }

        public enum ExamSubject1
        {
            CoreJava,
            AdvanceJava,
            CSharp
        }

        public enum ExamStatus
        {
            Done,
            UpComing,
            OnGoing
        }
    }

    public enum Teacher
    {
        Jayalakshmi =1,
        JohnCater = 2,
        HienPa = 3


    }

    public enum ClassRoomSt
    {
        B10 = 1,
        B16 = 2,
        B14 = 3
    }
}