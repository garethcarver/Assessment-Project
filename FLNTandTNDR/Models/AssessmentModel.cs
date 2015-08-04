using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FLNTandTNDR.Models
{
    public class AssessmentModel
    {
        public bool DataSpecified { get; set; }
        public string Company { get; set; }
        public string Logo { get; set; }
        public string Website { get; set; }
        public string AssessmentReviewer { get; set; }
        public string ReviewerPosition { get; set; }
        public string ReviewerEmail { get; set; }
        public string Candidate { get; set; }
        public string CandidateIdNo { get; set; }
        public string CandidateEmail { get; set; }
        public string CandidatePrimaryContactNo { get; set; }
        public string CandidateProfileLinks { get; set; }
        public string AssessmentPlatform { get; set; }
        public string TestCriteria { get; set; }
        public string TestData { get; set; }
        public DateTime AssessmentExpectedDate { get; set; }
    }
}