using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.Xml.Serialization;

namespace TaskLib
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

        public QuestionCL(string question, int difficulty, List<AnswerCL> answers)
        {
            this.Question = question;
            this.Difficulty = difficulty;
            this.Answers = answers;
        }

    }

    public class TestCL
    {
        public string Author { get; set; }
        public string TestName { get; set; }
        public List<QuestionCL> Questions { get; set; }

        public TestCL() { }
        public TestCL(string author, string testName, List<QuestionCL> questions)
        {
            this.Author = author;
            this.TestName = testName;
            this.Questions = questions;
        }
    }

    public class ListTestCL
    {
        public List<TestCL> Tests = new List<TestCL>();

        XmlSerializer xs = new XmlSerializer(typeof(List<TestCL>), new XmlRootAttribute("Tasks"));

        XDocument doc;

        public void SerializeTestCL(string fileName, TestCL test)
        {
            using (FileStream fs = new FileStream(fileName + ".xml", FileMode.OpenOrCreate))
            {
                xs.Serialize(fs, test);
            }
        }

        public TestCL DeserializeTestCL(string fileName)
        {
            TestCL test;

            using (FileStream fs = new FileStream(fileName, FileMode.OpenOrCreate))
            {
                test = (TestCL)xs.Deserialize(fs);
                return test;
            }
        }
    }









}
