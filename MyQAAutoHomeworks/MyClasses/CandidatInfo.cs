using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyClasses
{
     class CandidateInfo
    {
        public Person personInfo;
        public SubjectScore[] subjectScores;

        public CandidateInfo(Person person, SubjectScore[] score)
        {
            personInfo = person;
            subjectScores = score;
        }
}   }
