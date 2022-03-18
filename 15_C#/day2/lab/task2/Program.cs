string s = "this is a test";

string[] subs = s.Split(' ');
string reversed = "";

for (int i= subs.Length-1;i>=0;--i)
{
    reversed += subs[i];
    reversed += " ";
}
Console.WriteLine(reversed);
