using Exams;
Exam exam1 = new FinalExam(3,1526,"sub1");
Exam exam2 = new PracticeExam(2,152,"sub3");

string[] quest1 = { "hard1", "hard2" };
string[] quest2 = { "hard1", "hard2", "hard3" };
exam1.addMCQ("what is c++", 3, quest1, 0);
exam1.addMCQ("what is sql", 5, quest2, 2);

exam2.addMCQ("what is XML", 3, quest1, 0);
exam2.addTF("is JS dumm", 1, true);

Console.WriteLine("enter 0 for Final, enter 1 for Pracitcal");
int choose;
bool success = int.TryParse(Console.ReadLine(), out choose);
if (success)
{
    if (choose == 0) exam1.show();
    if (choose == 1) exam2.show();
}



