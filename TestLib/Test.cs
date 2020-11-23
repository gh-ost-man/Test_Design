using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.Xml.Serialization;

namespace TestLib
{

    public class AnswerCL
    {
        public string Answer { get; set; }
        public bool IsRight { get; set; }

        public AnswerCL() { }

        public AnswerCL(string answer, bool isRight)
        {
            this.Answer = answer;
            this.IsRight = isRight;
        }
    }

    public class QuestionCL
    {
        public string Question { get; set; }
        public int Difficulty { get; set; }

        public List<AnswerCL> Answers { get; set; }

        public QuestionCL() { }

        public QuestionCL(string question, List<AnswerCL> answers, int difficulty)
        {
            this.Question = question;
            this.Answers = answers;
            this.Difficulty = difficulty;
        }
    }

    public class TestCL
    {
        public string Author { get; set; }
        public List<QuestionCL> Questions { get; set; }

        public TestCL() { }

        public TestCL(string author, List<QuestionCL> questions)
        {
            this.Author = author;
            this.Questions = questions;
        }
    }

    public class ListTests
    {
        public List<TestCL> Tests = new List<TestCL>();

        XmlSerializer xsListTestCL = new XmlSerializer(typeof(List<TestCL>), new XmlRootAttribute("Test"));
        XmlSerializer xsTestCL = new XmlSerializer(typeof(List<TestCL>), new XmlRootAttribute("Test"));
        XDocument doc;


        public void SerializeXmlFileTest(string fileName, TestCL test)
        {
            using (FileStream fs = new FileStream("Tasks.xml", FileMode.OpenOrCreate))
            {
                xsTestCL.Serialize(fs, test);
            }
        }

        public void DeserializeXmlFile(string path)
        {
            TestCL testCL;

            using (FileStream fs = new FileStream("Tasks.xml", FileMode.OpenOrCreate))
            {
                testCL = (TestCL)xsTestCL.Deserialize(fs);
            }
        }

    }

}
